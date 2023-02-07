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
    public partial class DohodFizForm : Form
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
        int idv = 0;
        int idf = 0;
        public DohodFizForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idDoh, FirstNameF as 'Фамилия', MiddleNameF as 'Имя' ,NameDohFiz as 'Вид дохода', InnFiz as 'ИНН физ лица', Year as 'Год получения', Month as 'Месяц получения', Cost as 'Величина дохода' FROM dohodFiz p INNER JOIN IstokdohodFiz ps ON ps.idDohFiz = idisdoh INNER JOIN fizlica pd ON pd.idFiz = idF ORDER BY idDoh", dataBaseConnection);
            dataAdapter.Fill(ds, "dohodFiz");
            DT = ds.Tables["dohodFiz"];
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
            if (VidBox.Text == "" || InnBox.Text == "" || YearBox.Text == "" || MonthBox.Text == "" || CostBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idDohFiz FROM IstokdohodFiz WHERE NameDohFiz = '" + VidBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idDohFiz", idv);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idv = Convert.ToInt32(reader["idDohFiz"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                SqlCommand selectIdf = new SqlCommand("SELECT idFiz FROM fizlica WHERE InnFiz = '" + InnBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdf.Parameters.AddWithValue("idFiz", idf);
                try
                {
                    SqlDataReader reader = selectIdf.ExecuteReader();
                    while (reader.Read())
                    {
                        idf = Convert.ToInt32(reader["idFiz"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO dohodFiz (idF, idisdoh, Year, Month, Cost)VALUES(@idF, @idisdoh, @Year, @Month, @Cost)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("idisdoh", idv);
                createUser.Parameters.AddWithValue("idF", idf);
                createUser.Parameters.AddWithValue("Year", YearBox.Text);
                createUser.Parameters.AddWithValue("Month", MonthBox.Text);
                createUser.Parameters.AddWithValue("Cost", CostBox.Text);
                try
                {
                    createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void DohodFizForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectCity = new SqlCommand("SELECT [InnFiz] FROM [fizlica]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectCity.ExecuteReader();
            InnBox.Items.Clear();
            while (sqlReader.Read())
            {
                InnBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();

            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectfiznalog = new SqlCommand("SELECT [NameDohFiz] FROM [IstokdohodFiz]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectfiznalog.ExecuteReader();
            VidBox.Items.Clear();
            while (sqlReader.Read())
            {
                VidBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
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
                string commTextt = "delete from dohodFiz where idDoh = @idDoh";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idDoh", MainTable[0, MainTable.CurrentRow.Index].Value);
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
