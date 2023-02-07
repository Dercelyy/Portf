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
    public partial class AddFizNalogForm : Form
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader sqlReader = null;
        DataSet ds;
        SqlConnection dataBaseConnection;
        SqlDataAdapter dataAdapter;
        BindingSource bindingsourse1;
        DataTable DT = new DataTable();
        SqlCommandBuilder cb;
        int idf = 0;
        int idv = 0;
        int summopl = 0;
        int opl = 0;
        int dolg = 0;
        string connectionString;
        public AddFizNalogForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (VidBox.Text == "" || InnBox.Text == "" || SummBox.Text == "" || DateOBox.Text == "" || DateOplBox.Text == "" || DateOplBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idVidnalog FROM vidnalogfiz WHERE NameFizNalog = '" + VidBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idVidnalog", idv);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idv = Convert.ToInt32(reader["idVidnalog"]);
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
                summopl = Convert.ToInt32(SummBox.Text);
                opl = Convert.ToInt32(SummOplBox.Text);
                dolg = summopl - opl;
                if(dolg == 0)
                {
                    string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nalogfiz (idVid, idF, OblSumm, DateOpovesh, DateOpl, Oplata, Oplacheno, Dolg)VALUES(@idVid, @idF, @OblSumm, @DateOpovesh, @DateOpl, @Oplata, @Oplacheno, @Dolg)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVid", idv);
                    createUser.Parameters.AddWithValue("idF", idf);
                    createUser.Parameters.AddWithValue("OblSumm", SummBox.Text);
                    createUser.Parameters.AddWithValue("DateOpovesh", DateOBox.Text);
                    createUser.Parameters.AddWithValue("DateOpl", DateOplBox.Text);
                    createUser.Parameters.AddWithValue("Oplata", SummOplBox.Text);
                    createUser.Parameters.AddWithValue("Oplacheno", 1);
                    createUser.Parameters.AddWithValue("Dolg", dolg);
                    try
                    {
                        createUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    NalogFizForm fizfrm = new NalogFizForm();
                    fizfrm.Show();
                    this.Close();
                }
                else
                {
                    string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nalogfiz (idVid, idF, OblSumm, DateOpovesh, DateOpl, Oplata, Oplacheno, Dolg)VALUES(@idVid, @idF, @OblSumm, @DateOpovesh, @DateOpl, @Oplata, @Oplacheno, @Dolg)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVid", idv);
                    createUser.Parameters.AddWithValue("idF", idf);
                    createUser.Parameters.AddWithValue("OblSumm", SummBox.Text);
                    createUser.Parameters.AddWithValue("DateOpovesh", DateOBox.Text);
                    createUser.Parameters.AddWithValue("DateOpl", DateOplBox.Text);
                    createUser.Parameters.AddWithValue("Oplata", SummOplBox.Text);
                    createUser.Parameters.AddWithValue("Oplacheno", 0);
                    createUser.Parameters.AddWithValue("Dolg", dolg);
                    try
                    {
                        createUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    NalogFizForm fizfrm = new NalogFizForm();
                    fizfrm.Show();
                    this.Close();
                }
            }
        }

        private void AddFizNalogForm_Load(object sender, EventArgs e)
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
            SqlCommand selectfiznalog = new SqlCommand("SELECT [NameFizNalog] FROM [vidnalogfiz]", sqlConnection);
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
    }
}
