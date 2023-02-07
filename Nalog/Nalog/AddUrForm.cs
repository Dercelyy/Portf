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
    public partial class AddUrForm : Form
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader sqlReader = null;
        DataSet ds;
        SqlConnection dataBaseConnection;
        SqlDataAdapter dataAdapter;
        BindingSource bindingsourse1;
        DataTable DT = new DataTable();
        SqlCommandBuilder cb;
        int idc = 0;
        int idd = 0;
        string connectionString;
        public AddUrForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FBox.Text == "" || DBox.Text == "" || PhoneBox.Text == "" || INNBox.Text == "" || CityBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idCity FROM city WHERE NameCity = '" + CityBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idCity", idc);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idc = Convert.ToInt32(reader["idCity"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                SqlCommand selectIdd = new SqlCommand("SELECT idDeyat FROM deyaturlic WHERE NameDeyat = '" + DBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdd.Parameters.AddWithValue("idDeyat", idd);
                try
                {
                    SqlDataReader reader = selectIdd.ExecuteReader();
                    while (reader.Read())
                    {
                        idd = Convert.ToInt32(reader["idDeyat"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO urlica (innurlic, NameOrg, deatelnost, idCit, Ulica, Dom, Kvart, Phone, Site)VALUES(@innurlic, @NameOrg, @deatelnost, @idCit, @Ulica, @Dom, @Kvart, @Phone, @Site)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("innurlic", INNBox.Text);
                createUser.Parameters.AddWithValue("NameOrg", FBox.Text);
                createUser.Parameters.AddWithValue("deatelnost", idd);
                createUser.Parameters.AddWithValue("idCit", idc);
                createUser.Parameters.AddWithValue("Ulica", UlBox.Text);
                createUser.Parameters.AddWithValue("Dom", DomBox.Text);
                createUser.Parameters.AddWithValue("Kvart", KvBox.Text);
                createUser.Parameters.AddWithValue("Phone", PhoneBox.Text);
                createUser.Parameters.AddWithValue("Site", MailBox.Text);
                try
                {
                    createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                URLForm urfrm = new URLForm();
                urfrm.Show();
                this.Close();
            }
        }

        private void AddUrForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectCity = new SqlCommand("SELECT [NameCity] FROM [city]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectCity.ExecuteReader();
            CityBox.Items.Clear();
            while (sqlReader.Read())
            {
                CityBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectD = new SqlCommand("SELECT [NameDeyat] FROM [deyaturlic]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectD.ExecuteReader();
            DBox.Items.Clear();
            while (sqlReader.Read())
            {
                DBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            URLForm urfrm = new URLForm();
            urfrm.Show();
            this.Close();
        }
    }
}
