namespace UserLoginProject
{
    partial class Form1
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
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnName1 = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.btnName2 = new System.Windows.Forms.Button();
            this.dgvName1 = new System.Windows.Forms.DataGridView();
            this.btnName3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(42, 307);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(308, 26);
            this.txtBox2.TabIndex = 0;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(42, 244);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(308, 26);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnName1
            // 
            this.btnName1.Location = new System.Drawing.Point(37, 485);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(121, 36);
            this.btnName1.TabIndex = 2;
            this.btnName1.Text = "Ekle";
            this.btnName1.UseVisualStyleBackColor = true;
            this.btnName1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(38, 221);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(38, 20);
            this.lblName1.TabIndex = 3;
            this.lblName1.Text = "İsim";
            this.lblName1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(43, 284);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(69, 20);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "Soy İsim";
            this.lblName2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(42, 366);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(308, 26);
            this.txtBox3.TabIndex = 5;
            this.txtBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(42, 429);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(308, 26);
            this.txtBox4.TabIndex = 6;
            // 
            // lblName4
            // 
            this.lblName4.AutoSize = true;
            this.lblName4.Location = new System.Drawing.Point(43, 406);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(115, 20);
            this.lblName4.TabIndex = 7;
            this.lblName4.Text = "E-Posta Adresi";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(43, 343);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(54, 20);
            this.lblName3.TabIndex = 8;
            this.lblName3.Text = "Tel No";
            // 
            // btnName2
            // 
            this.btnName2.Location = new System.Drawing.Point(229, 485);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(121, 36);
            this.btnName2.TabIndex = 9;
            this.btnName2.Text = "Düzenle";
            this.btnName2.UseVisualStyleBackColor = true;
            // 
            // dgvName1
            // 
            this.dgvName1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvName1.Location = new System.Drawing.Point(743, 244);
            this.dgvName1.Name = "dgvName1";
            this.dgvName1.RowHeadersWidth = 62;
            this.dgvName1.RowTemplate.Height = 28;
            this.dgvName1.Size = new System.Drawing.Size(256, 234);
            this.dgvName1.TabIndex = 10;
            this.dgvName1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnName3
            // 
            this.btnName3.Location = new System.Drawing.Point(862, 485);
            this.btnName3.Name = "btnName3";
            this.btnName3.Size = new System.Drawing.Size(137, 37);
            this.btnName3.TabIndex = 11;
            this.btnName3.Text = "Sil";
            this.btnName3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 716);
            this.Controls.Add(this.btnName3);
            this.Controls.Add(this.dgvName1);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName4);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.txtBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvName1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnName1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Button btnName2;
        private System.Windows.Forms.DataGridView dgvName1;
        private System.Windows.Forms.Button btnName3;
    }
}

