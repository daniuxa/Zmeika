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
    public partial class GameForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Dota.wav");
        Zmei zmei = null;
        Apple apple = null;
        int Score = 0;
        Direction direction = Direction.Up;
        const int intervalWithBorders = 400;
        const int intervalWithoutBorders = 300;
        bool WithBorders = true;
        int StartSize = 0;
        private string UserName = "";
        const string connectionString = "Server=DESKTOP-HAL50HT;Database=Zmeika;Integrated Security=True;TrustServerCertificate=True;Pooling=true";
        const string SelectUserName = "SELECT * FROM UserRecords";


        public GameForm(bool WithBorders, string UserName)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.WithBorders = WithBorders;
            this.UserName = UserName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // player.PlayLooping();
            pictureBox1.Visible = false;
            if (WithBorders == true)
            {
                StartSize = 10;
                timer1.Interval = intervalWithBorders;
            }            
            else
            {
                StartSize = 17;
                timer1.Interval = intervalWithoutBorders;
            }

            try
            {
                zmei = new Zmei(StartSize);
            }
            catch (SizeException ex)
            {
                MessageBox.Show(ex.Message + "/tValue: " + ex.Value);
                Application.Exit();
            }
            apple = new Apple(zmei.body);
            ScoreNumText.Text = Score.ToString();           
        }

        private void GameZone_Paint(object sender, PaintEventArgs e)
        {
            int Result = 0;
            bool IncreaseSnake = false;

            if (WithBorders == true)
            {
                Pen pen1 = new Pen(Color.Brown, 3);
                e.Graphics.DrawRectangle(pen1, new Rectangle(0, 0, 410, 410));
            }
            

            if (zmei.body[0] == apple.Point)
            {
                apple.NewPos(zmei.body);
                IncreaseSnake = true;
                if (WithBorders == true)
                {
                    timer1.Interval -= timer1.Interval / 5;
                }
                else
                {
                    timer1.Interval -= timer1.Interval / 8;
                }
                Score++;
                ScoreNumText.Text = Score.ToString();
            }
            apple.Show(e);

            Result = zmei.Move(e, direction, WithBorders, IncreaseSnake);
            if (Result == 1)
            {
                timer1.Stop();
                //this.BackgroundImage = Image.FromFile("Ded.jpg");
                pictureBox1.Visible = true;
                NewGame("Lost Game");
                
            }
            else if (Result == 2)
            {
                timer1.Stop();
                pictureBox1.Visible = true;
                NewGame("Won Game");
            }

           // ScoreLabel.Text = zmei.body[0].X.ToString() + "  " + zmei.body[0].Y.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            GameZone.Invalidate();
        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                direction = Direction.Left;
            }
            else if (e.KeyCode == Keys.Up)
            {
                direction = Direction.Up;
            }
            else if (e.KeyCode == Keys.Right)
            {
                direction = Direction.Right;
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = Direction.Down;
            }          
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TopBorder_Paint(object sender, PaintEventArgs e)
        {

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

        private void NewGame(string result)
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
                    if ((string)item["UserName"] != UserName)
                    {
                        continue;
                    }
                    if (WithBorders)
                    {
                        if ((item["RecordScoreWithBorder"] == DBNull.Value ? 0 : (int)item["RecordScoreWithBorder"]) < Score)
                        {
                            item["RecordScoreWithBorder"] = Score;
                        }
                    }
                    else
                    {
                        if ((item["RecordScoreWithoutBorder"] == DBNull.Value ? 0 : (int)item["RecordScoreWithoutBorder"]) < Score)
                        {
                            item["RecordScoreWithoutBorder"] = Score;
                        }
                    }
                }
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            DialogResult dialog = MessageBox.Show($"Хотите еще сыграть?\n\nСчет в игре: {Score}", result, MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Zmei zmei = new Zmei(StartSize);
                this.zmei = zmei;
                apple.NewPos(zmei.body);
                direction = Direction.Up;
                Score = 0;
                this.ScoreNumText.Text = Score.ToString();
                if (WithBorders == true)
                {
                    timer1.Interval = intervalWithBorders;
                }
                else
                {
                    timer1.Interval = intervalWithoutBorders;
                }
                pictureBox1.Visible = false;
                timer1.Start();
            }
            else
            {
                player.Stop();
                this.Close();

            }
            
           
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void GameZone_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void TopBorder_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TopBorder_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void GameZone_Click(object sender, EventArgs e)
        {
           
        }

        private void GameZone_Enter(object sender, EventArgs e)
        {
            
        }

        private void CloseButtn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CloseButtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButtn_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void CloseButtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
