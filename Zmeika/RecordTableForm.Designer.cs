namespace Zmeika
{
    partial class RecordTableForm
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
            this.TopBorder = new System.Windows.Forms.Panel();
            this.CloseButtn = new System.Windows.Forms.Button();
            this.RecordDataGridView = new System.Windows.Forms.DataGridView();
            this.ChangeBordersButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TopBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Silver;
            this.TopBorder.Controls.Add(this.CloseButtn);
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(0, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(623, 30);
            this.TopBorder.TabIndex = 18;
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
            this.CloseButtn.Location = new System.Drawing.Point(595, 2);
            this.CloseButtn.Name = "CloseButtn";
            this.CloseButtn.Size = new System.Drawing.Size(25, 25);
            this.CloseButtn.TabIndex = 15;
            this.CloseButtn.Text = "X";
            this.CloseButtn.UseVisualStyleBackColor = false;
            this.CloseButtn.Click += new System.EventHandler(this.CloseButtn_Click);
            // 
            // RecordDataGridView
            // 
            this.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordDataGridView.Location = new System.Drawing.Point(0, 36);
            this.RecordDataGridView.Name = "RecordDataGridView";
            this.RecordDataGridView.RowHeadersWidth = 51;
            this.RecordDataGridView.RowTemplate.Height = 24;
            this.RecordDataGridView.Size = new System.Drawing.Size(611, 353);
            this.RecordDataGridView.TabIndex = 16;
            this.RecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordDataGridView_CellContentClick);
            // 
            // ChangeBordersButton
            // 
            this.ChangeBordersButton.Location = new System.Drawing.Point(0, 395);
            this.ChangeBordersButton.Name = "ChangeBordersButton";
            this.ChangeBordersButton.Size = new System.Drawing.Size(127, 43);
            this.ChangeBordersButton.TabIndex = 19;
            this.ChangeBordersButton.Text = "Без бортиков";
            this.ChangeBordersButton.UseVisualStyleBackColor = true;
            this.ChangeBordersButton.Click += new System.EventHandler(this.ChangeBordersButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(545, 405);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 33);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(464, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 33);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RecordTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ChangeBordersButton);
            this.Controls.Add(this.RecordDataGridView);
            this.Controls.Add(this.TopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordTableForm";
            this.Text = "RecordTableForm";
            this.Load += new System.EventHandler(this.RecordTableForm_Load);
            this.TopBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Button CloseButtn;
        private System.Windows.Forms.DataGridView RecordDataGridView;
        private System.Windows.Forms.Button ChangeBordersButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
    }
}