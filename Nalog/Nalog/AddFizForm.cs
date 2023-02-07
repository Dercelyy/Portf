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
    public partial class AddFizForm : Form
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
        string connectionString;
        public AddFizForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FBox.Text == "" || MBox.Text == "" || LBox.Text == "" || INNBox.Text == "" || CityBox.Text == "")
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
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO fizlica (FirstNameF, MiddleNameF, LastNameF, InnFiz, DateBirth, idCit, Ulica, Dom, Kvartira, SerPasp, NomPasp, DateVidachi, Phone, Mail)VALUES(@FirstNameF, @MiddleNameF, @LastNameF, @InnFiz, @DateBirth, @idCit, @Ulica, @Dom, @Kvartira, @SerPasp, @NomPasp, @DateVidachi, @Phone, @Mail)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("FirstNameF", FBox.Text);
                createUser.Parameters.AddWithValue("MiddleNameF", MBox.Text);
                createUser.Parameters.AddWithValue("LastNameF", LBox.Text);
                createUser.Parameters.AddWithValue("InnFiz", INNBox.Text);
                createUser.Parameters.AddWithValue("DateBirth", BirthBox.Text);
                createUser.Parameters.AddWithValue("idCit", idc);
                createUser.Parameters.AddWithValue("Ulica", UlBox.Text);
                createUser.Parameters.AddWithValue("Dom", DomBox.Text);
                createUser.Parameters.AddWithValue("Kvartira", KvBox.Text);
                createUser.Parameters.AddWithValue("SerPasp", SerBox.Text);
                createUser.Parameters.AddWithValue("NomPasp", NomBox.Text);
                createUser.Parameters.AddWithValue("DateVidachi", DateBox.Text);
                createUser.Parameters.AddWithValue("Phone", PhoneBox.Text);
                createUser.Parameters.AddWithValue("Mail", MailBox.Text);
                try
                {
                    createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                FizForm fizfrm = new FizForm();
                fizfrm.Show();
                this.Close();
            }
        }

        private void AddFizForm_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FizForm fizfrm = new FizForm();
            fizfrm.Show();
            this.Close();
        }
    }
}
