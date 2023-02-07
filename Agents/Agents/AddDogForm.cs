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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Agents
{
    public partial class AddDogForm : MaterialForm
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
        int idvladelec = 0;
        int ida = 0;
        int idc = 0;
        int idn = 0;
        public AddDogForm()
        {
            InitializeComponent();
        }

        private void AddDogForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectCity = new SqlCommand("SELECT [FirstNameA] FROM [agents]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectCity.ExecuteReader();
            AgentBox.Items.Clear();
            while (sqlReader.Read())
            {
                AgentBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();

            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectVlad = new SqlCommand("SELECT FirstNameV FROM vladelec", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectVlad.ExecuteReader();
            VladBox.Items.Clear();
            while (sqlReader.Read())
            {
                VladBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();

            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectVid = new SqlCommand("SELECT [FirstName] FROM [clients]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectVid.ExecuteReader();
            ClientBox.Items.Clear();
            while (sqlReader.Read())
            {
                ClientBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
        }

        private void VladBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectTeacher = new SqlCommand("SELECT idVladelec FROM vladelec Where FirstNameV = '" + VladBox.Text + "'", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectTeacher.ExecuteReader();
            NedvishBox.Items.Clear();
            while (sqlReader.Read())
            {
                idv = Convert.ToInt32(sqlReader["idVladelec"]);
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();

            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectNed = new SqlCommand("SELECT Name, idN FROM nedvish Where idVlad = '" + idv + "'", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectNed.ExecuteReader();
            NedvishBox.Items.Clear();
            while (sqlReader.Read())
            {
                NedvishBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DateTime registrationDate = DateTime.Now;
            if (VladBox.Text == "" || ClientBox.Text == "" || AgentBox.Text == "" || NedvishBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idVladelec FROM vladelec WHERE FirstNameV = '" + VladBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idVladelec", idvladelec);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idvladelec = Convert.ToInt32(reader["idVladelec"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                SqlCommand selectIdvid = new SqlCommand("SELECT idClient FROM clients WHERE FirstName = '" + ClientBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdvid.Parameters.AddWithValue("idClient", idc);
                try
                {
                    SqlDataReader reader = selectIdvid.ExecuteReader();
                    while (reader.Read())
                    {
                        idc = Convert.ToInt32(reader["idClient"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                SqlCommand selectIdcity = new SqlCommand("SELECT idAgent FROM agents WHERE FirstNameA = '" + AgentBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdcity.Parameters.AddWithValue("idAgent", ida);
                try
                {
                    SqlDataReader reader = selectIdcity.ExecuteReader();
                    while (reader.Read())
                    {
                        ida = Convert.ToInt32(reader["idAgent"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                SqlCommand selectIdclass = new SqlCommand("SELECT idN FROM nedvish WHERE Name = '" + NedvishBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdclass.Parameters.AddWithValue("idN", idn);
                try
                {
                    SqlDataReader reader = selectIdclass.ExecuteReader();
                    while (reader.Read())
                    {
                        idn = Convert.ToInt32(reader["idN"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                string connectString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO dogovors (idA, idNed, idC, idVladel, Date)VALUES(@idA, @idNed, @idC, @idVladel, @Date)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("idA", ida);
                createUser.Parameters.AddWithValue("idNed", idn);
                createUser.Parameters.AddWithValue("idC", idc);
                createUser.Parameters.AddWithValue("idVladel", idvladelec);
                createUser.Parameters.AddWithValue("Date", registrationDate.ToShortDateString());
                try
                {
                    createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                DogovorForm dogfrm = new DogovorForm();
                dogfrm.Show();
                this.Close();
            }
        }
    }
}
