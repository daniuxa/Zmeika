namespace Zmeika
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseButtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameWithBorderButton = new System.Windows.Forms.Button();
            this.GameWithoutBorderButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RecordWithBordersLabel = new System.Windows.Forms.Label();
            this.RecordWithoutBorders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordTableButton = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButtn);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(528, 30);
            this.TopBorder.TabIndex = 17;
            this.TopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseDown);
            this.TopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorder_MouseMove);
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
            this.CloseButtn.Location = new System.Drawing.Point(503, 2);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(25, 25);
            this.CloseButtn.TabIndex = 15;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Начать игру?";
            // 
            // GameWithBorderButton
            // 
            this.GameWithBorderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameWithBorderButton.Location = new System.Drawing.Point(12, 260);
            this.GameWithBorderButton.Name = "GameWithBorderButton";
            this.GameWithBorderButton.Size = new System.Drawing.Size(138, 46);
            this.GameWithBorderButton.TabIndex = 19;
            this.GameWithBorderButton.Text = "С бортиками";
            this.GameWithBorderButton.UseVisualStyleBackColor = true;
            this.GameWithBorderButton.Click += new System.EventHandler(this.GameWithBorderButton_Click);
            // 
            // GameWithoutBorderButton
            // 
            this.GameWithoutBorderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameWithoutBorderButton.Location = new System.Drawing.Point(378, 260);
            this.GameWithoutBorderButton.Name = "GameWithoutBorderButton";
            this.GameWithoutBorderButton.Size = new System.Drawing.Size(138, 46);
            this.GameWithoutBorderButton.TabIndex = 20;
            this.GameWithoutBorderButton.Text = "Обычная";
            this.GameWithoutBorderButton.UseVisualStyleBackColor = true;
            this.GameWithoutBorderButton.Click += new System.EventHandler(this.GameWithoutBorderButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(215, 115);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(89, 20);
            this.UserNameLabel.TabIndex = 23;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RecordWithBordersLabel
            // 
            this.RecordWithBordersLabel.AutoSize = true;
            this.RecordWithBordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordWithBordersLabel.Location = new System.Drawing.Point(36, 309);
            this.RecordWithBordersLabel.Name = "RecordWithBordersLabel";
            this.RecordWithBordersLabel.Size = new System.Drawing.Size(73, 20);
            this.RecordWithBordersLabel.TabIndex = 24;
            this.RecordWithBordersLabel.Text = "Record: ";
            // 
            // RecordWithoutBorders
            // 
            this.RecordWithoutBorders.AutoSize = true;
            this.RecordWithoutBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordWithoutBorders.Location = new System.Drawing.Point(411, 309);
            this.RecordWithoutBorders.Name = "RecordWithoutBorders";
            this.RecordWithoutBorders.Size = new System.Drawing.Size(73, 20);
            this.RecordWithoutBorders.TabIndex = 25;
            this.RecordWithoutBorders.Text = "Record: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Имя игрока:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RecordTableButton
            // 
            this.RecordTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordTableButton.Location = new System.Drawing.Point(173, 394);
            this.RecordTableButton.Name = "RecordTableButton";
            this.RecordTableButton.Size = new System.Drawing.Size(183, 80);
            this.RecordTableButton.TabIndex = 27;
            this.RecordTableButton.Text = "Таблица рекордов";
            this.RecordTableButton.UseVisualStyleBackColor = true;
            this.RecordTableButton.Click += new System.EventHandler(this.RecordTableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 486);
            this.Controls.Add(this.RecordTableButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecordWithoutBorders);
            this.Controls.Add(this.RecordWithBordersLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.GameWithoutBorderButton);
            this.Controls.Add(this.GameWithBorderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameWithBorderButton;
        private System.Windows.Forms.Button GameWithoutBorderButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RecordWithBordersLabel;
        private System.Windows.Forms.Label RecordWithoutBorders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RecordTableButton;
    }
}