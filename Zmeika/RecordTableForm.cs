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
    public partial class RecordTableForm : Form
    {
        Point LastPoint;
        int pageNext = 0;
        
        const string connectionString = "Server=DESKTOP-HAL50HT;Database=Zmeika;Integrated Security=True;TrustServerCertificate=True;Pooling=true";
        string SelectWithBorders;
        string SelectWithoutBorders;
        bool WithBorders = true;

        public RecordTableForm()
        {
            InitializeComponent();
            SelectWithBorders = @"SELECT UserName, RecordScoreWithBorder FROM UserRecords 
                                           WHERE RecordScoreWithBorder IS NOT NULL
                                           ORDER BY RecordScoreWithBorder DESC
                                           OFFSET " + pageNext * 10 + @" ROWS
                                           FETCH NEXT 10 ROWS ONLY";
            SelectWithoutBorders = @"SELECT UserName, RecordScoreWithoutBorder FROM UserRecords 
                                           WHERE RecordScoreWithoutBorder IS NOT NULL
                                           ORDER BY RecordScoreWithoutBorder DESC
                                           OFFSET " + pageNext * 10 + @" ROWS
                                           FETCH NEXT 10 ROWS ONLY";
        }

        private void ShowWithBorders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataSet dataSet = new DataSet();
                SqlCommand command = new SqlCommand(SelectWithBorders, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet);
                RecordDataGridView.DataSource = dataSet.Tables[0];
            }
        }
        private void ShowWithoutBorders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataSet dataSet = new DataSet();
                SqlCommand command = new SqlCommand(SelectWithoutBorders, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet);
                RecordDataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void RecordTableForm_Load(object sender, EventArgs e)
        {
            ShowWithBorders();
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

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (RecordDataGridView.Rows.Count == 10)
            {
                pageNext++;
                if (WithBorders)
                {
                    ShowWithBorders();
                }
                else
                {
                    ShowWithoutBorders();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (pageNext != 0)
            {
                pageNext--;
                if (WithBorders)
                {
                    ShowWithBorders();
                }
                else
                {
                    ShowWithoutBorders();
                }
            }
        }

        private void ChangeBordersButton_Click(object sender, EventArgs e)
        {
            pageNext = 0;
            if (WithBorders)
            {
                ChangeBordersButton.Text = "С бортиками";
                ShowWithoutBorders();
                WithBorders = false;
            }
            else
            {
                ChangeBordersButton.Text = "Без бортиков";
                ShowWithBorders();
                WithBorders = true;
            }
        }

        private void RecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
