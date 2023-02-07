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
    public partial class MainForm : MaterialForm
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
        public static int id = 0;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idN, FirstNameV as 'Владелец', NameV as 'Вид' ,Name as 'Название', Ploshad as 'Площадь', NameClass as 'Класс жилья', NameСity as 'Город', Street as 'Улица', Cost as 'Стоимость', Comnati as 'Количество комнат', Floors as 'Этаж', Zalog as 'Залог' FROM nedvish p INNER JOIN city ps ON ps.idCity = City INNER JOIN vid pd ON pd.idVid = idVidd INNER JOIN class pg ON pg.idClass = Class INNER JOIN vladelec pl ON pl.idVladelec = idVlad ORDER BY idN", dataBaseConnection);
            dataAdapter.Fill(ds, "nedvish");
            DT = ds.Tables["nedvish"];
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

        private void MainForm_Load(object sender, EventArgs e)
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

        private void sbrosButton_Click(object sender, EventArgs e)
        {
            LoadData();
            CityBox.Text = "";
        }

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            connectionString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
            dataBaseConnection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(" SELECT idN, FirstNameV as 'Владелец', NameV as 'Вид' ,Name as 'Название', Ploshad as 'Площадь', NameClass as 'Класс жилья', NameСity as 'Город', Street as 'Улица', Cost as 'Стоимость', Comnati as 'Количество комнат', Floors as 'Этаж', Zalog as 'Залог' FROM nedvish p INNER JOIN city ps ON ps.idCity = City INNER JOIN vid pd ON pd.idVid = idVidd INNER JOIN class pg ON pg.idClass = Class INNER JOIN vladelec pl ON pl.idVladelec = idVlad WHERE NameСity = '"+ CityBox.Text+"' ORDER BY idN", dataBaseConnection);
            dataAdapter.Fill(ds, "nedvish");
            DT = ds.Tables["nedvish"];
            bindingsourse1 = new BindingSource();
            bindingsourse1.DataSource = DT;
            MainTable.DataSource = ds.Tables[0];
            MainTable.Columns[0].Visible = false;
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNForm anfrm = new AddNForm();
            anfrm.Show();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE nedvish SET Name='" + MainTable[3, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Ploshad='" + MainTable[4, MainTable.SelectedCells[0].RowIndex].Value.ToString()
                + "', Street='" + MainTable[7, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "',Zalog = '" + MainTable[11, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Cost ='" + MainTable[8, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Comnati='" + MainTable[9, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "', Floors='" + MainTable[10, MainTable.SelectedCells[0].RowIndex].Value.ToString()
                 + "' WHERE idN='" + MainTable[0, MainTable.SelectedCells[0].RowIndex].Value.ToString() + "'"; ;

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
                string connectString = ConfigurationManager.ConnectionStrings["AgentsConnectionString"].ConnectionString;
                SqlConnection myConnection = new SqlConnection(connectString);
                string commTextt = "delete from nedvish where idN = @idN";
                myConnection.Open();
                SqlTransaction transactiont = myConnection.BeginTransaction();
                SqlCommand commt = new SqlCommand(commTextt, myConnection);
                commt.Transaction = transactiont;
                commt.Parameters.AddWithValue("@idN", MainTable[0, MainTable.CurrentRow.Index].Value);
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

        private void vidButton_Click(object sender, EventArgs e)
        {
            VidForm vidfrm = new VidForm();
            vidfrm.Show();
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            CityForm cfrm = new CityForm();
            cfrm.Show();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            ClassForm clfrm = new ClassForm();
            clfrm.Show();
        }

        private void agentButton_Click(object sender, EventArgs e)
        {
            AgentForm agfrm = new AgentForm();
            agfrm.Show();
        }

        private void VladButton_Click(object sender, EventArgs e)
        {
            VladForm vlfrm = new VladForm();
            vlfrm.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientForm clientfrm = new ClientForm();
            clientfrm.Show();
        }

        private void DogovorButton_Click(object sender, EventArgs e)
        {
            DogovorForm dogfrm = new DogovorForm();
            dogfrm.Show();
        }

        private void SoldButton_Click(object sender, EventArgs e)
        {
            SoldForm soldfrm = new SoldForm();
            soldfrm.Show();
        }
    }
}
