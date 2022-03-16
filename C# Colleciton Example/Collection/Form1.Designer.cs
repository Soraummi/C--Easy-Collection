namespace ATP10A_2012
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
            this.btnsehir = new System.Windows.Forms.Button();
            this.txtsehirgiris = new System.Windows.Forms.TextBox();
            this.lstbyazdir = new System.Windows.Forms.ListBox();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsecilen = new System.Windows.Forms.Button();
            this.txtarayaekle = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtbguncelle = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.txtvarmi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsehir
            // 
            this.btnsehir.Location = new System.Drawing.Point(12, 33);
            this.btnsehir.Name = "btnsehir";
            this.btnsehir.Size = new System.Drawing.Size(58, 23);
            this.btnsehir.TabIndex = 0;
            this.btnsehir.Text = "Şehir Giriniz";
            this.btnsehir.UseVisualStyleBackColor = true;
            this.btnsehir.Click += new System.EventHandler(this.btnsehir_Click);
            // 
            // txtsehirgiris
            // 
            this.txtsehirgiris.Location = new System.Drawing.Point(76, 36);
            this.txtsehirgiris.Name = "txtsehirgiris";
            this.txtsehirgiris.Size = new System.Drawing.Size(64, 20);
            this.txtsehirgiris.TabIndex = 1;
            // 
            // lstbyazdir
            // 
            this.lstbyazdir.FormattingEnabled = true;
            this.lstbyazdir.Location = new System.Drawing.Point(220, 79);
            this.lstbyazdir.Name = "lstbyazdir";
            this.lstbyazdir.Size = new System.Drawing.Size(151, 108);
            this.lstbyazdir.TabIndex = 3;
            // 
            // btnyazdir
            // 
            this.btnyazdir.Location = new System.Drawing.Point(258, 50);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(75, 23);
            this.btnyazdir.TabIndex = 4;
            this.btnyazdir.Text = "Yazdır";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Araya Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsecilen
            // 
            this.btnsecilen.Location = new System.Drawing.Point(37, 146);
            this.btnsecilen.Name = "btnsecilen";
            this.btnsecilen.Size = new System.Drawing.Size(58, 22);
            this.btnsecilen.TabIndex = 6;
            this.btnsecilen.Text = "Sil";
            this.btnsecilen.UseVisualStyleBackColor = true;
            this.btnsecilen.Click += new System.EventHandler(this.btnsecilen_Click_2);
            // 
            // txtarayaekle
            // 
            this.txtarayaekle.Location = new System.Drawing.Point(76, 88);
            this.txtarayaekle.Name = "txtarayaekle";
            this.txtarayaekle.Size = new System.Drawing.Size(64, 20);
            this.txtarayaekle.TabIndex = 8;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(12, 118);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(58, 23);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click_1);
            // 
            // txtbguncelle
            // 
            this.txtbguncelle.Location = new System.Drawing.Point(76, 120);
            this.txtbguncelle.Name = "txtbguncelle";
            this.txtbguncelle.Size = new System.Drawing.Size(64, 20);
            this.txtbguncelle.TabIndex = 10;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(12, 60);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(58, 23);
            this.btnara.TabIndex = 11;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click_1);
            // 
            // txtvarmi
            // 
            this.txtvarmi.Location = new System.Drawing.Point(76, 62);
            this.txtvarmi.Name = "txtvarmi";
            this.txtvarmi.Size = new System.Drawing.Size(64, 20);
            this.txtvarmi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 285);
            this.Controls.Add(this.txtvarmi);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtbguncelle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtarayaekle);
            this.Controls.Add(this.btnsecilen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.lstbyazdir);
            this.Controls.Add(this.txtsehirgiris);
            this.Controls.Add(this.btnsehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsehir;
        private System.Windows.Forms.TextBox txtsehirgiris;
        private System.Windows.Forms.ListBox lstbyazdir;
        private System.Windows.Forms.Button btnyazdir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsecilen;
        private System.Windows.Forms.TextBox txtarayaekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtbguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtvarmi;
    }
}

