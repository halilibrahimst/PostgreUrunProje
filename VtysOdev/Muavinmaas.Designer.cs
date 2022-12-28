namespace VtysOdev
{
    partial class Muavinmaas
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
            this.Arabtn = new System.Windows.Forms.Button();
            this.Güncellebtn = new System.Windows.Forms.Button();
            this.Silbtn = new System.Windows.Forms.Button();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.İsimtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tclbl = new System.Windows.Forms.Label();
            this.isimlabel = new System.Windows.Forms.Label();
            this.TctextBox = new System.Windows.Forms.TextBox();
            this.Listelebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Arabtn
            // 
            this.Arabtn.Location = new System.Drawing.Point(1300, 557);
            this.Arabtn.Margin = new System.Windows.Forms.Padding(6);
            this.Arabtn.Name = "Arabtn";
            this.Arabtn.Size = new System.Drawing.Size(193, 59);
            this.Arabtn.TabIndex = 43;
            this.Arabtn.Text = "Ara";
            this.Arabtn.UseVisualStyleBackColor = true;
            this.Arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // Güncellebtn
            // 
            this.Güncellebtn.Location = new System.Drawing.Point(1300, 464);
            this.Güncellebtn.Margin = new System.Windows.Forms.Padding(6);
            this.Güncellebtn.Name = "Güncellebtn";
            this.Güncellebtn.Size = new System.Drawing.Size(193, 59);
            this.Güncellebtn.TabIndex = 42;
            this.Güncellebtn.Text = "Güncelle";
            this.Güncellebtn.UseVisualStyleBackColor = true;
            this.Güncellebtn.Click += new System.EventHandler(this.Güncellebtn_Click);
            // 
            // Silbtn
            // 
            this.Silbtn.Location = new System.Drawing.Point(1300, 360);
            this.Silbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(193, 59);
            this.Silbtn.TabIndex = 41;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // Eklebtn
            // 
            this.Eklebtn.Location = new System.Drawing.Point(1300, 250);
            this.Eklebtn.Margin = new System.Windows.Forms.Padding(6);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(193, 59);
            this.Eklebtn.TabIndex = 40;
            this.Eklebtn.Text = "Ekle";
            this.Eklebtn.UseVisualStyleBackColor = true;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // İsimtextBox
            // 
            this.İsimtextBox.Location = new System.Drawing.Point(979, 257);
            this.İsimtextBox.Margin = new System.Windows.Forms.Padding(6);
            this.İsimtextBox.Name = "İsimtextBox";
            this.İsimtextBox.Size = new System.Drawing.Size(256, 37);
            this.İsimtextBox.TabIndex = 37;
            this.İsimtextBox.TextChanged += new System.EventHandler(this.İsimtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(705, 530);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tclbl
            // 
            this.Tclbl.AutoSize = true;
            this.Tclbl.Location = new System.Drawing.Point(824, 158);
            this.Tclbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Tclbl.Name = "Tclbl";
            this.Tclbl.Size = new System.Drawing.Size(84, 30);
            this.Tclbl.TabIndex = 35;
            this.Tclbl.Text = "Muavin";
            this.Tclbl.Click += new System.EventHandler(this.Tclbl_Click);
            // 
            // isimlabel
            // 
            this.isimlabel.AutoSize = true;
            this.isimlabel.Location = new System.Drawing.Point(824, 257);
            this.isimlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(64, 30);
            this.isimlabel.TabIndex = 34;
            this.isimlabel.Text = "Maaş";
            this.isimlabel.Click += new System.EventHandler(this.isimlabel_Click);
            // 
            // TctextBox
            // 
            this.TctextBox.Location = new System.Drawing.Point(979, 158);
            this.TctextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TctextBox.Name = "TctextBox";
            this.TctextBox.Size = new System.Drawing.Size(256, 37);
            this.TctextBox.TabIndex = 33;
            this.TctextBox.TextChanged += new System.EventHandler(this.TctextBox_TextChanged);
            // 
            // Listelebtn
            // 
            this.Listelebtn.Location = new System.Drawing.Point(1300, 167);
            this.Listelebtn.Margin = new System.Windows.Forms.Padding(6);
            this.Listelebtn.Name = "Listelebtn";
            this.Listelebtn.Size = new System.Drawing.Size(193, 59);
            this.Listelebtn.TabIndex = 32;
            this.Listelebtn.Text = "Listele";
            this.Listelebtn.UseVisualStyleBackColor = true;
            this.Listelebtn.Click += new System.EventHandler(this.Listelebtn_Click);
            // 
            // Muavinmaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1531, 817);
            this.Controls.Add(this.Arabtn);
            this.Controls.Add(this.Güncellebtn);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.İsimtextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tclbl);
            this.Controls.Add(this.isimlabel);
            this.Controls.Add(this.TctextBox);
            this.Controls.Add(this.Listelebtn);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Muavinmaas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muavinmaas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Arabtn;
        private Button Güncellebtn;
        private Button Silbtn;
        private Button Eklebtn;
        private TextBox İsimtextBox;
        private DataGridView dataGridView1;
        private Label Tclbl;
        private Label isimlabel;
        private TextBox TctextBox;
        private Button Listelebtn;
    }
}