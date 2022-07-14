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
    public partial class MainForm : Form
    {
        const string connectionString = "Server=DESKTOP-HAL50HT;Database=Zmeika;Integrated Security=True;TrustServerCertificate=True;Pooling=true";
        const string SelectUserName = "SELECT * FROM UserRecords";
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Music.wav");
        bool PlayerStoped = true;
        private string UserName = "";
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;
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

        private void GameWithBorderButton_Click(object sender, EventArgs e)
        {
           // player.Stop();
            GameForm frm = new GameForm(true, UserName);
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
            NewScore();
        }

        private void GameWithoutBorderButton_Click(object sender, EventArgs e)
        {
           // player.Stop();
            GameForm frm = new GameForm(false, UserName);
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
            NewScore();
        }

        private void NewScore()
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

                foreach (DataRow item in table.Rows)
                {
                    if ((string)item["UserName"] == UserName)
                    {
                        RecordWithBordersLabel.Text = "Рекорд: " + (item["RecordScoreWithBorder"] == DBNull.Value ? 0 : (int)item["RecordScoreWithBorder"]);
                        RecordWithoutBorders.Text = "Рекорд: " + (item["RecordScoreWithoutBorder"] == DBNull.Value ? 0 : (int)item["RecordScoreWithoutBorder"]);
                        break;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckOpen();
            UserNameLabel.Text = UserName;
            NewScore();
        }

        private async void CheckOpen()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if (this.Visible == false && PlayerStoped == false)
                    {
                        player.Stop();
                        PlayerStoped = true;
                    }
                    else if(this.Visible == true && PlayerStoped == true)
                    {
                        player.PlayLooping();
                        PlayerStoped = false;
                    }
                }
            });
        }

        private void RecordTableButton_Click(object sender, EventArgs e)
        {
            RecordTableForm recordTableForm = new RecordTableForm();
            this.Visible = false;
            recordTableForm.ShowDialog();
            this.Visible = true;
        }
    }
}
