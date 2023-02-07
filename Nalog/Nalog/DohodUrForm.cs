﻿using System;
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
    public partial class DohodUrForm : Form
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
        int idu = 0;
        int idd = 0;
        public DohodUrForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idDohY, NameOrg as 'Организация',NameDeyat as 'Деятельность', innurlic as 'ИНН юр лица', years as 'Год получения', month as 'Месяц получения', costy as 'Величина дохода' FROM dohodUr p INNER JOIN deyaturlic ps ON ps.idDeyat = idDey INNER JOIN urlica pd ON pd.idUr = idUrlic ORDER BY idDohY", dataBaseConnection);
            dataAdapter.Fill(ds, "dohodUr");
            DT = ds.Tables["dohodUr"];
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
        private void DohodUrForm_Load(object sender, EventArgs e)
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
        }

        private void InnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand selectIdclass = new SqlCommand("SELECT deatelnost FROM urlica WHERE innurlic = '" + Convert.ToInt32(InnBox.Text) + "'", sqlConnection);
            sqlConnection.Open();
            selectIdclass.Parameters.AddWithValue("deatelnost", idd);
            try
            {
                SqlDataReader reader = selectIdclass.ExecuteReader();
                while (reader.Read())
                {
                    idd = Convert.ToInt32(reader["deatelnost"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();

            connectionString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand selectfiznalog = new SqlCommand("SELECT [NameDeyat] FROM [deyaturlic] WHERE idDeyat ='"+ idd + "'", sqlConnection);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (VidBox.Text == "" || InnBox.Text == "" || YearBox.Text == "" || MonthBox.Text == "" || CostBox.Text == "")
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand selectId = new SqlCommand("SELECT idDeyat FROM deyaturlic WHERE NameDeyat = '" + VidBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectId.Parameters.AddWithValue("idDeyat", idv);
                try
                {
                    SqlDataReader reader = selectId.ExecuteReader();
                    while (reader.Read())
                    {
                        idv = Convert.ToInt32(reader["idDeyat"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                SqlCommand selectIdf = new SqlCommand("SELECT idUr FROM urlica WHERE innurlic = '" + InnBox.Text + "'", sqlConnection);
                sqlConnection.Open();
                selectIdf.Parameters.AddWithValue("idUr", idu);
                try
                {
                    SqlDataReader reader = selectIdf.ExecuteReader();
                    while (reader.Read())
                    {
                        idu = Convert.ToInt32(reader["idUr"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                string connectString = ConfigurationManager.ConnectionStrings["nalogConnectionString"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand createUser = new SqlCommand("INSERT INTO dohodUr (idDey, idUrlic, years, month, costy)VALUES(@idDey, @idUrlic, @years, @month, @costy)", sqlConnection);
                sqlConnection.Open();
                createUser.Parameters.AddWithValue("idDey", idv);
                createUser.Parameters.AddWithValue("idUrlic", idu);
                createUser.Parameters.AddWithValue("years", YearBox.Text);
                createUser.Parameters.AddWithValue("month", MonthBox.Text);
                createUser.Parameters.AddWithValue("costy", CostBox.Text);
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
                string commTextt = "delete from dohodUr where idDohY = @idDohY";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idDohY", MainTable[0, MainTable.CurrentRow.Index].Value);
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
