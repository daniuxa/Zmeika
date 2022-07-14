using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmeika
{
    public partial class LogInForm : Form
    {
        private Point LastPoint;
        const string connectionString = "Server=DESKTOP-HAL50HT;Database=Zmeika;Integrated Security=True;TrustServerCertificate=True;Pooling=true";
        const string SelectUserName = "SELECT UserName FROM UserRecords";
        DataSet dataSet;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                return;
            }
            if (!UserNameTextBox.AutoCompleteCustomSource.Contains(UserNameTextBox.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataSet dataSet = new DataSet();
                    SqlCommand command = new SqlCommand(SelectUserName, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = command;

                    dataAdapter.Fill(dataSet);
                    DataTable table = dataSet.Tables[0];

                    DataRow row = table.NewRow();
                    row["UserName"] = UserNameTextBox.Text;
                    try
                    {
                        table.Rows.Add(row);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        dataAdapter.Update(dataSet);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MainForm mainForm = new MainForm(UserNameTextBox.Text);
            this.Visible = false;
            mainForm.ShowDialog();
            this.Visible = true;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SelectUserName, connection);
                dataAdapter.SelectCommand = command;
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
            }
            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                UserNameTextBox.AutoCompleteCustomSource.Add((string)item[0]);
            }

        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
