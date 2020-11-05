namespace MSMA1
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
            this.button1 = new System.Windows.Forms.Button();
            this.arabaDgw = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUnlem = new System.Windows.Forms.Label();
            this.tbxIdUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxAciklamaUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFiyatUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxModelUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMarkaUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.arabaDgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Uygulamadan Çık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arabaDgw
            // 
            this.arabaDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.arabaDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arabaDgw.Location = new System.Drawing.Point(12, 40);
            this.arabaDgw.Name = "arabaDgw";
            this.arabaDgw.Size = new System.Drawing.Size(775, 187);
            this.arabaDgw.TabIndex = 2;
            this.arabaDgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.arabaDgw_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(712, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Aracı Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(47, 166);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAciklama);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir Araç Ekleyin";
            // 
            // tbxAciklama
            // 
            this.tbxAciklama.Location = new System.Drawing.Point(9, 120);
            this.tbxAciklama.Multiline = true;
            this.tbxAciklama.Name = "tbxAciklama";
            this.tbxAciklama.Size = new System.Drawing.Size(138, 40);
            this.tbxAciklama.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Açıklama : ";
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(47, 77);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxFiyat.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fiyat";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(47, 51);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model";
            // 
            // tbxMarka
            // 
            this.tbxMarka.Location = new System.Drawing.Point(47, 24);
            this.tbxMarka.Name = "tbxMarka";
            this.tbxMarka.Size = new System.Drawing.Size(100, 20);
            this.tbxMarka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUnlem);
            this.groupBox2.Controls.Add(this.tbxIdUpdate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxAciklamaUpdate);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxFiyatUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxModelUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxMarkaUpdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(587, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 215);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bir Araç Güncelleyin";
            // 
            // lblUnlem
            // 
            this.lblUnlem.AutoSize = true;
            this.lblUnlem.BackColor = System.Drawing.SystemColors.Control;
            this.lblUnlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlem.ForeColor = System.Drawing.Color.Red;
            this.lblUnlem.Location = new System.Drawing.Point(154, 20);
            this.lblUnlem.Name = "lblUnlem";
            this.lblUnlem.Size = new System.Drawing.Size(12, 16);
            this.lblUnlem.TabIndex = 16;
            this.lblUnlem.Text = "!";
            this.lblUnlem.Visible = false;
            // 
            // tbxIdUpdate
            // 
            this.tbxIdUpdate.Location = new System.Drawing.Point(47, 18);
            this.tbxIdUpdate.Name = "tbxIdUpdate";
            this.tbxIdUpdate.ReadOnly = true;
            this.tbxIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxIdUpdate.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Id";
            // 
            // tbxAciklamaUpdate
            // 
            this.tbxAciklamaUpdate.Location = new System.Drawing.Point(9, 140);
            this.tbxAciklamaUpdate.Multiline = true;
            this.tbxAciklamaUpdate.Name = "tbxAciklamaUpdate";
            this.tbxAciklamaUpdate.Size = new System.Drawing.Size(138, 40);
            this.tbxAciklamaUpdate.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Açıklama : ";
            // 
            // tbxFiyatUpdate
            // 
            this.tbxFiyatUpdate.Location = new System.Drawing.Point(47, 97);
            this.tbxFiyatUpdate.Name = "tbxFiyatUpdate";
            this.tbxFiyatUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxFiyatUpdate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fiyat";
            // 
            // tbxModelUpdate
            // 
            this.tbxModelUpdate.Location = new System.Drawing.Point(47, 71);
            this.tbxModelUpdate.Name = "tbxModelUpdate";
            this.tbxModelUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxModelUpdate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Model";
            // 
            // tbxMarkaUpdate
            // 
            this.tbxMarkaUpdate.Location = new System.Drawing.Point(47, 44);
            this.tbxMarkaUpdate.Name = "tbxMarkaUpdate";
            this.tbxMarkaUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxMarkaUpdate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Marka";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(311, 249);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arabaDgw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.arabaDgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView arabaDgw;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxAciklamaUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFiyatUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxModelUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxMarkaUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxIdUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUnlem;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

