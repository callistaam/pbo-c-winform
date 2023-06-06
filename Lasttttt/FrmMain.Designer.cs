namespace Lasttttt
{
    partial class FrmMain
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
            this.btnInput = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbHarga = new System.Windows.Forms.Label();
            this.lbStok = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.btnBeli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.Transparent;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInput.Location = new System.Drawing.Point(891, 192);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(154, 56);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dgData
            // 
            this.dgData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(42, 316);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 82;
            this.dgData.RowTemplate.Height = 33;
            this.dgData.Size = new System.Drawing.Size(1027, 362);
            this.dgData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Penjualan Laptop";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNama.Location = new System.Drawing.Point(78, 150);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(92, 35);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama";
            // 
            // lbHarga
            // 
            this.lbHarga.AutoSize = true;
            this.lbHarga.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHarga.Location = new System.Drawing.Point(78, 203);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(93, 35);
            this.lbHarga.TabIndex = 2;
            this.lbHarga.Text = "Harga";
            // 
            // lbStok
            // 
            this.lbStok.AutoSize = true;
            this.lbStok.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStok.Location = new System.Drawing.Point(78, 256);
            this.lbStok.Name = "lbStok";
            this.lbStok.Size = new System.Drawing.Size(73, 35);
            this.lbStok.TabIndex = 2;
            this.lbStok.Text = "Stok";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(263, 152);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(466, 31);
            this.tbNama.TabIndex = 3;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(263, 205);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(466, 31);
            this.tbHarga.TabIndex = 3;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(263, 258);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(466, 31);
            this.tbStok.TabIndex = 3;
            // 
            // btnBeli
            // 
            this.btnBeli.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.Location = new System.Drawing.Point(84, 697);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(179, 60);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1066, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1114, 784);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbStok);
            this.Controls.Add(this.lbHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.Label lbStok;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label label2;
    }
}

