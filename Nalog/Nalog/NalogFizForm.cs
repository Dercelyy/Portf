using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nalog
{
    public partial class NalogFizForm : Form
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader sqlReader = null;
        DataSet ds;
        SqlConnection dataBaseConnection;
        SqlDataAdapter dataAdapter;
        BindingSource bindingsourse1;
        DataTable DT = new DataTable();
        SqlCommandBuilder cb;
        string connectionString;
        public NalogFizForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idFN, FirstNameF as 'Фамилия', MiddleNameF as 'Имя' ,NameFizNalog as 'Вид налога', InnFiz as 'ИНН физ лица', OblSumm as 'Облагаемая сумма', DateOpovesh as 'Дата получения извещения', DateOpl as 'Дата оплаты', Oplata as 'Оплачено', Oplacheno as 'Оплатил', Dolg as 'Долг' FROM nalogfiz p INNER JOIN vidnalogfiz ps ON ps.idVidnalog = idVid INNER JOIN fizlica pd ON pd.idFiz = idF ORDER BY idFN", dataBaseConnection);
            dataAdapter.Fill(ds, "nalogfiz");
            DT = ds.Tables["nalogfiz"];
            bindingsourse1 = new BindingSource();
            bindingsourse1.DataSource = DT;
            MainTable.DataSource = ds.Tables[0];
            MainTable.Columns[0].Visible = false;
        }
        public static int LevenshteinDistance(string string1, string string2)
        {
            if (string1 == null) throw new ArgumentNullException("string1");
            if (string2 == null) throw new ArgumentNullException("string2");
            int diff;
            int[,] m = new int[string1.Length + 1, string2.Length + 1];

            for (int i = 0; i <= string1.Length; i++) { m[i, 0] = i; }
            for (int j = 0; j <= string2.Length; j++) { m[0, j] = j; }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;

                    m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1,
                                             m[i, j - 1] + 1),
                                             m[i - 1, j - 1] + diff);
                }
            }
            return m[string1.Length, string2.Length];
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddFizNalogForm nfrm = new AddFizNalogForm();
            nfrm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE nalogfiz SET DateOpl='" + MainTable[7, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Oplata='" + MainTable[8, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Oplacheno='" + MainTable[9, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Dolg='" + MainTable[10, MainTable.SelectedCells[0].RowIndex].Value.ToString()
              + "' WHERE idFN='" + MainTable[0, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "'"; ;

            dataBaseConnection.Open();
            dataAdapter.UpdateCommand = dataBaseConnection.CreateCommand();
            dataAdapter.UpdateCommand.CommandText = sql;
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            dataBaseConnection.Close();
            bindingsourse1.EndEdit();
            dataAdapter.Update(DT);
            MessageBox.Show("Обновленно");
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MainTable[0, MainTable.CurrentRow.Index].Value == "")
            {
                MessageBox.Show("Не выделена удаляемая запись");
            }
            else
            {
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                SqlConnection myConnection = new SqlConnection(connectString);
                string commTextt = "delete from nalogfiz where idFN = @idFN";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idFN", MainTable[0, MainTable.CurrentRow.Index].Value);
                try
                {
                    commt.ExecuteNonQuery();
                    transactiont.Commit();
                    MessageBox.Show("Запись удалена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transactiont.Rollback();
                }
                myConnection.Close();
                LoadData();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MainTable.RowCount; i++)
            {
                MainTable.Rows[1].Selected = false;
                int j = 1;
                if (MainTable.Rows[i].Cells[j].Value != null)
                    if (LevenshteinDistance(MainTable.Rows[i].Cells[j].Value.ToString(), SearchBox.Text) <= 1)
                    {
                        MainTable.Rows[i].Selected = true;
                        break;
                    }
            }
        }
    }
}
