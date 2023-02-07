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
    public partial class CityForm : Form
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
        public CityForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idCity, NameCity as 'Название Города' FROM city", dataBaseConnection);
            dataAdapter.Fill(ds, "city");
            DT = ds.Tables["city"];
            bindingsourse1 = new BindingSource();
            bindingsourse1.DataSource = DT;
            MainTable.DataSource = ds.Tables[0];
            MainTable.Columns[0].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO city (NameCity)VALUES(@NameCity)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("NameCity", NameBox.Text);
                try
                {
                    createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                LoadData();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE city SET NameCity='" + MainTable[1, MainTable.SelectedCells[0].RowIndex].Value.ToString()
                + "' WHERE idCity='" + MainTable[0, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "'"; ;

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
                string commTextt = "delete from city where idCity = @idCity";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idCity", MainTable[0, MainTable.CurrentRow.Index].Value);
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
    }
}
