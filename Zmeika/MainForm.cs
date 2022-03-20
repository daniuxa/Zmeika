using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmeika
{
    public partial class MainForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"GLAD.wav");
        bool PlayerStoped = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            GameForm frm = new GameForm(true);
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void GameWithoutBorderButton_Click(object sender, EventArgs e)
        {
           // player.Stop();
            GameForm frm = new GameForm(false);
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckOpen();
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
    }
}
