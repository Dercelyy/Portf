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
    public partial class UpnForm : MaterialForm
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
        int Id = MainForm.id;
        string connectionString;
        public UpnForm()
        {
            InitializeComponent();
        }

        private void UpnForm_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand upd = new SqlCommand("SELECT [Name], [Ploshad], [Street], [Cost], [Comnati], [Floors] FROM [nedvish] WHERE [idN] ="+ Id, sqlConnection);
            sqlConnection.Open();
            upd.Parameters.AddWithValue("Name", NameBox.Text);
            upd.Parameters.AddWithValue("Ploshad", PloshBox.Text);
            upd.Parameters.AddWithValue("Street", StreetBox.Text);
            upd.Parameters.AddWithValue("Cost", CostBox.Text);
            upd.Parameters.AddWithValue("Comnati", ComnBox.Text);
            upd.Parameters.AddWithValue("Floors", FloorBox.Text);
            try
            {
                upd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            sqlConnection.Close();
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
            SqlCommand selectVlad = new SqlCommand("SELECT [FirstName] FROM [vladelec]", sqlConnection);
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
                if (ZalogBox.Checked)
                {
                    string sql = "UPDATE nedvish SET idVlad ='" + idv + "', idVidd = '" + idvid + "', Name = '" + NameBox.Text + "', Ploshad = '" + PloshBox.Text + "', City = '" + idc + "'" +
                   ", Street ='" + StreetBox.Text + "', Cost = '" + CostBox.Text + "', Comnati = '" + ComnBox.Text + "', Floors = '" + FloorBox.Text + "', Zalog ='" + idt + "', Class = '" + idcl + "'";

                    dataBaseConnection.Open();
                    dataAdapter.UpdateCommand = dataBaseConnection.CreateCommand();
                    dataAdapter.UpdateCommand.CommandText = sql;
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    dataBaseConnection.Close();
                    bindingsourse1.EndEdit();
                    dataAdapter.Update(DT);
                    MainForm anfrm = new MainForm();
                    anfrm.Show();
                    this.Close();
                }
                else
                {
                    string sql = "UPDATE nedvish SET idVlad ='" + idv + "', idVidd = '" + idvid + "', Name = '" + NameBox.Text + "', Ploshad = '" + PloshBox.Text + "', City = '" + idc + "'" +
                   ", Street ='" + StreetBox.Text + "', Cost = '" + CostBox.Text + "', Comnati = '" + ComnBox.Text + "', Floors = '" + FloorBox.Text + "', Zalog ='" + idf + "', Class = '" + idcl + "'";

                    dataBaseConnection.Open();
                    dataAdapter.UpdateCommand = dataBaseConnection.CreateCommand();
                    dataAdapter.UpdateCommand.CommandText = sql;
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    dataBaseConnection.Close();
                    bindingsourse1.EndEdit();
                    dataAdapter.Update(DT);
                    MainForm anfrm = new MainForm();
                    anfrm.Show();
                    this.Close();
                }
            }
        }
    }
}
