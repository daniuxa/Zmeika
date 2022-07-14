
namespace Zmeika
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameZone = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ScoreNumText = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseButtn = new System.Windows.Forms.Button();
            this.GameZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameZone
            // 
            this.GameZone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameZone.Controls.Add(this.pictureBox1);
            this.GameZone.Location = new System.Drawing.Point(0, 49);
            this.GameZone.Margin = new System.Windows.Forms.Padding(0);
            this.GameZone.Name = "GameZone";
            this.GameZone.Size = new System.Drawing.Size(412, 412);
            this.GameZone.TabIndex = 0;
            this.GameZone.Click += new System.EventHandler(this.GameZone_Click);
            this.GameZone.Paint += new System.Windows.Forms.PaintEventHandler(this.GameZone_Paint);
            this.GameZone.Enter += new System.EventHandler(this.GameZone_Enter);
            this.GameZone.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameZone_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Zmeika.Properties.Resources.Ded;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 412);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuPanel.Controls.Add(this.ScoreNumText);
            this.MenuPanel.Controls.Add(this.ScoreLabel);
            this.MenuPanel.Location = new System.Drawing.Point(0, 24);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(412, 24);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            this.MenuPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MenuPanel_PreviewKeyDown);
            // 
            // ScoreNumText
            // 
            this.ScoreNumText.AutoSize = true;
            this.ScoreNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreNumText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreNumText.Location = new System.Drawing.Point(46, 2);
            this.ScoreNumText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreNumText.Name = "ScoreNumText";
            this.ScoreNumText.Size = new System.Drawing.Size(45, 17);
            this.ScoreNumText.TabIndex = 1;
            this.ScoreNumText.Text = "Score";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(2, 2);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(45, 17);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButtn);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(412, 24);
            this.TopBorder.TabIndex = 16;
            this.TopBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBorder_Paint_1);
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
            this.TopBorder.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TopBorder_PreviewKeyDown);
            // 
            // CloseButtn
            // 
            this.CloseButtn.BackColor = System.Drawing.Color.Red;
            this.CloseButtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButtn.FlatAppearance.BorderSize = 0;
            this.CloseButtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButtn.Location = new System.Drawing.Point(392, 2);
            this.CloseButtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(19, 20);
            this.CloseButtn.TabIndex = 15;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click_1);
            this.CloseButtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseButtn_KeyDown_1);
            this.CloseButtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CloseButtn_PreviewKeyDown);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 461);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TopBorder);
            this.Controls.Add(this.GameZone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.GameZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameZone;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.Label ScoreNumText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

