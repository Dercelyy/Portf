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
    public partial class URLForm : Form
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
        public URLForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idUr, NameOrg as 'Организация', innurlic as 'ИНН юр лица' ,NameDeyat as 'Деятельность Юр лиц', NameCity as 'Город', Ulica as 'Улица', Dom as 'Дом', Kvart as 'Квартира', Phone as 'Телефон', Site as 'Сайт' FROM urlica p INNER JOIN city ps ON ps.idCity = idCit INNER JOIN deyaturlic pd ON pd.idDeyat = deatelnost ORDER BY idUr", dataBaseConnection);
            dataAdapter.Fill(ds, "urlica");
            DT = ds.Tables["urlica"];
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
            AddUrForm ffrm = new AddUrForm();
            ffrm.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE urlica SET NameOrg='" + MainTable[1, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', innurlic='" + MainTable[2, MainTable.SelectedCells[0].RowIndex].Value.ToString()
               + "', Ulica ='" + MainTable[5, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Dom='" + MainTable[6, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Kvart='" + MainTable[7, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Phone='" + MainTable[8, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Site='" + MainTable[9, MainTable.SelectedCells[0].RowIndex].Value.ToString()
                + "' WHERE idUr='" + MainTable[0, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "'"; ;

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
                string commTextt = "delete from urlica where idUr = @idUr";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idUr", MainTable[0, MainTable.CurrentRow.Index].Value);
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

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idUr, NameOrg as 'Организация', innurlic as 'ИНН юр лица' ,NameDeyat as 'Деятельность Юр лиц', NameCity as 'Город', Ulica as 'Улица', Dom as 'Дом', Kvart as 'Квартира', Phone as 'Телефон', Site as 'Сайт' FROM urlica p INNER JOIN city ps ON ps.idCity = idCit INNER JOIN deyaturlic pd ON pd.idDeyat = deatelnost WHERE NameCity = '" + CityBox.Text + "' ORDER BY idUr", dataBaseConnection);
            dataAdapter.Fill(ds, "urlica");
            DT = ds.Tables["urlica"];
            bindingsourse1 = new BindingSource();
            bindingsourse1.DataSource = DT;
            MainTable.DataSource = ds.Tables[0];
            MainTable.Columns[0].Visible = false;
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            LoadData();
            CityBox.Text = "";
        }
    }
}
