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
    public partial class AddUrNalogForm : Form
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
        public AddUrNalogForm()
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
                SqlCommand selectId = new SqlCommand("SELECT idVidNalog FROM vidnalogur WHERE NameVidNalog = '" + VidBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idVidNalog", idv);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idv = Convert.ToInt32(reader["idVidNalog"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                SqlCommand selectIdf = new SqlCommand("SELECT idUr FROM urlica WHERE innurlic = '" + InnBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdf.Parameters.AddWithValue("idUr", idf);
                try
                {
                    SqlDataReader reader = selectIdf.ExecuteReader();
                    while (reader.Read())
                    {
                        idf = Convert.ToInt32(reader["idUr"]);
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
                if (dolg == 0)
                {
                    string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nalogur (idVid, idU, OblSumm, DateOpovesh, DateOplata, Oplacheno, Oplata, Dolg)VALUES(@idVid, @idU, @OblSumm, @DateOpovesh, @DateOplata, @Oplacheno, @Oplata, @Dolg)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVid", idv);
                    createUser.Parameters.AddWithValue("idU", idf);
                    createUser.Parameters.AddWithValue("OblSumm", SummBox.Text);
                    createUser.Parameters.AddWithValue("DateOpovesh", DateOBox.Text);
                    createUser.Parameters.AddWithValue("DateOplata", DateOplBox.Text);
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
                    NalogUrForm urfrm = new NalogUrForm();
                    urfrm.Show();
                    this.Close();
                }
                else
                {
                    string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nalogur (idVid, idU, OblSumm, DateOpovesh, DateOplata, Oplacheno, Oplata, Dolg)VALUES(@idVid, @idU, @OblSumm, @DateOpovesh, @DateOplata, @Oplacheno, @Oplata, @Dolg)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVid", idv);
                    createUser.Parameters.AddWithValue("idU", idf);
                    createUser.Parameters.AddWithValue("OblSumm", SummBox.Text);
                    createUser.Parameters.AddWithValue("DateOpovesh", DateOBox.Text);
                    createUser.Parameters.AddWithValue("DateOplata", DateOplBox.Text);
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

        private void AddUrNalogForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectCity = new SqlCommand("SELECT [innurlic] FROM [urlica]", sqlConnection);
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
            SqlCommand selectfiznalog = new SqlCommand("SELECT [NameVidNalog] FROM [vidnalogur]", sqlConnection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            NalogFizForm fizfrm = new NalogFizForm();
            fizfrm.Show();
            this.Close();
        }
    }
}
