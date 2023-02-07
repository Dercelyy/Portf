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
    public partial class AddNForm : MaterialForm
    {
        private SqlConnection sqlConnection = null;
        SqlDataReader sqlReader = null;
        DataSet ds;
        SqlConnection dataBaseConnection;
        SqlDataAdapter dataAdapter;
        BindingSource bindingsourse1;
        DataTable DT = new DataTable();
        SqlCommandBuilder cb;
        int idv = 0;
        int idvid = 0;
        int idc = 0;
        int idcl = 0;
        int idt = 1;
        int idf = 0;
        string connectionString;
        public AddNForm()
        {
            InitializeComponent();
        }

        private void AddNForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectCity = new SqlCommand("SELECT [NameСity] FROM [city]", sqlConnection);
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

            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectVlad = new SqlCommand("SELECT [FirstNameV] FROM [vladelec]", sqlConnection);
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
            SqlCommand selectVid = new SqlCommand("SELECT [NameV] FROM [vid]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectVid.ExecuteReader();
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

            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectClass = new SqlCommand("SELECT [NameClass] FROM [Class]", sqlConnection);
            sqlConnection.Open();
            sqlReader = selectClass.ExecuteReader();
            ClassBox.Items.Clear();
            while (sqlReader.Read())
            {
                ClassBox.Items.Add(sqlReader.GetValue(0).ToString());
            }
            if (sqlReader != null && !sqlReader.IsClosed)
            {
                sqlReader.Close();
            }
            sqlConnection.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (VladBox.Text == "" || VidBox.Text == "" || NameBox.Text == "" || PloshBox.Text == "" || CityBox.Text == "" || StreetBox.Text == "" || ComnBox.Text == "" || FloorBox.Text == "" || CostBox.Text == "" || ClassBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idVladelec FROM vladelec WHERE FirstNameV = '" + VladBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idVladelec", idv);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idv = Convert.ToInt32(reader["idVladelec"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                SqlCommand selectIdvid = new SqlCommand("SELECT idVid FROM vid WHERE NameV = '" + VidBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdvid.Parameters.AddWithValue("idVid", idvid);
                try
                {
                    SqlDataReader reader = selectIdvid.ExecuteReader();
                    while (reader.Read())
                    {
                        idvid = Convert.ToInt32(reader["idVid"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();

                SqlCommand selectIdcity = new SqlCommand("SELECT idCity FROM city WHERE NameСity = '" + CityBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdcity.Parameters.AddWithValue("idCity", idc);
                try
                {
                    SqlDataReader reader = selectIdcity.ExecuteReader();
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

                SqlCommand selectIdclass = new SqlCommand("SELECT idClass FROM class WHERE NameClass = '" + ClassBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdclass.Parameters.AddWithValue("idClass", idcl);
                try
                {
                    SqlDataReader reader = selectIdclass.ExecuteReader();
                    while (reader.Read())
                    {
                        idcl = Convert.ToInt32(reader["idClass"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                if (ZalogBox.Checked)
                {
                    string connectString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nedvish (idVlad, idVidd, Name, Ploshad, City, Street, Cost, Comnati, Floors, Class, Zalog)VALUES(@idVlad, @idVidd, @Name, @Ploshad, @City, @Street, @Cost, @Comnati, @Floors, @Class, @Zalog)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVlad", idv);
                    createUser.Parameters.AddWithValue("idVidd", idvid);
                    createUser.Parameters.AddWithValue("Name", NameBox.Text);
                    createUser.Parameters.AddWithValue("Ploshad", PloshBox.Text);
                    createUser.Parameters.AddWithValue("City", idc);
                    createUser.Parameters.AddWithValue("Street", StreetBox.Text);
                    createUser.Parameters.AddWithValue("Cost", CostBox.Text);
                    createUser.Parameters.AddWithValue("Comnati", ComnBox.Text);
                    createUser.Parameters.AddWithValue("Floors", FloorBox.Text);
                    createUser.Parameters.AddWithValue("Class", idcl);
                    createUser.Parameters.AddWithValue("Zalog", idt);
                    try
                    {
                        createUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                    MainForm anfrm = new MainForm();
                    anfrm.Show();
                    this.Close();
                }
                else
                {
                    string connectString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    SqlCommand createUser = new SqlCommand("INSERT INTO nedvish (idVlad, idVidd, Name, Ploshad, City, Street, Cost, Comnati, Floors, Class, Zalog)VALUES(@idVlad, @idVidd, @Name, @Ploshad, @City, @Street, @Cost, @Comnati, @Floors, @Class, @Zalog)", sqlConnection);
                    sqlConnection.Open();
                    createUser.Parameters.AddWithValue("idVlad", idv);
                    createUser.Parameters.AddWithValue("idVidd", idvid);
                    createUser.Parameters.AddWithValue("Name", NameBox.Text);
                    createUser.Parameters.AddWithValue("Ploshad", PloshBox.Text);
                    createUser.Parameters.AddWithValue("City", idc);
                    createUser.Parameters.AddWithValue("Street", StreetBox.Text);
                    createUser.Parameters.AddWithValue("Cost", CostBox.Text);
                    createUser.Parameters.AddWithValue("Comnati", ComnBox.Text);
                    createUser.Parameters.AddWithValue("Floors", FloorBox.Text);
                    createUser.Parameters.AddWithValue("Class", idcl);
                    createUser.Parameters.AddWithValue("Zalog", idf);
                    try
                    {
                        createUser.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                    MainForm anfrm = new MainForm();
                    anfrm.Show();
                    this.Close();
                }
                
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm anfrm = new MainForm();
            anfrm.Show();
            this.Close();
        }
    }
}
