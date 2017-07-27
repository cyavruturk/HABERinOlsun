namespace xmlornek1
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
            this.btngetir = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lsvlistele = new System.Windows.Forms.ListView();
            this.clmhaberbasligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhaberlinki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wbtarayici = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(255, 3);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(87, 37);
            this.btngetir.TabIndex = 0;
            this.btngetir.Text = "Haberleri Getir";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(12, 12);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(237, 20);
            this.txturl.TabIndex = 1;
            // 
            // lsvlistele
            // 
            this.lsvlistele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhaberbasligi,
            this.clmhaberlinki});
            this.lsvlistele.GridLines = true;
            this.lsvlistele.Location = new System.Drawing.Point(12, 39);
            this.lsvlistele.Name = "lsvlistele";
            this.lsvlistele.Size = new System.Drawing.Size(329, 802);
            this.lsvlistele.TabIndex = 2;
            this.lsvlistele.UseCompatibleStateImageBehavior = false;
            this.lsvlistele.View = System.Windows.Forms.View.Details;
            this.lsvlistele.DoubleClick += new System.EventHandler(this.lsvlistele_DoubleClick);
            // 
            // clmhaberbasligi
            // 
            this.clmhaberbasligi.Text = "Haber Başlığı";
            this.clmhaberbasligi.Width = 86;
            // 
            // clmhaberlinki
            // 
            this.clmhaberlinki.Text = "Haber Linki";
            this.clmhaberlinki.Width = 189;
            // 
            // wbtarayici
            // 
            this.wbtarayici.Location = new System.Drawing.Point(348, 12);
            this.wbtarayici.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbtarayici.Name = "wbtarayici";
            this.wbtarayici.Size = new System.Drawing.Size(1058, 829);
            this.wbtarayici.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 853);
            this.Controls.Add(this.wbtarayici);
            this.Controls.Add(this.lsvlistele);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btngetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ListView lsvlistele;
        private System.Windows.Forms.WebBrowser wbtarayici;
        private System.Windows.Forms.ColumnHeader clmhaberbasligi;
        private System.Windows.Forms.ColumnHeader clmhaberlinki;
    }
}

