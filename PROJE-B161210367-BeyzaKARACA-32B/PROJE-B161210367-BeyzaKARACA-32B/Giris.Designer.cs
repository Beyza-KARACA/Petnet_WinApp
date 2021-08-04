namespace PROJE_B161210367_BeyzaKARACA_32B
{
    partial class LOGIN
    {
       private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.logtitle = new System.Windows.Forms.Label();
            this.logtitle2 = new System.Windows.Forms.Label();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.kayıtOlbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logtitle
            // 
            this.logtitle.AutoSize = true;
            this.logtitle.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logtitle.Location = new System.Drawing.Point(381, 12);
            this.logtitle.Name = "logtitle";
            this.logtitle.Size = new System.Drawing.Size(223, 59);
            this.logtitle.TabIndex = 0;
            this.logtitle.Text = "PETNET";
            this.logtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logtitle2
            // 
            this.logtitle2.AutoSize = true;
            this.logtitle2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtitle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.logtitle2.Location = new System.Drawing.Point(376, 106);
            this.logtitle2.Name = "logtitle2";
            this.logtitle2.Size = new System.Drawing.Size(239, 31);
            this.logtitle2.TabIndex = 1;
            this.logtitle2.Text = "KULLANICI GİRİŞİ";
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(285, 189);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(100, 16);
            this.kullaniciAdiLabel.TabIndex = 2;
            this.kullaniciAdiLabel.Text = "KULLANICI ADI";
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kullaniciAdiText.Location = new System.Drawing.Point(391, 185);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(213, 20);
            this.kullaniciAdiText.TabIndex = 4;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreLabel.Location = new System.Drawing.Point(285, 248);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(43, 16);
            this.sifreLabel.TabIndex = 5;
            this.sifreLabel.Text = "ŞİFRE";
            // 
            // sifreText
            // 
            this.sifreText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sifreText.Location = new System.Drawing.Point(391, 244);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(213, 20);
            this.sifreText.TabIndex = 6;
            this.sifreText.UseSystemPasswordChar = true;
            // 
            // girisButton
            // 
            this.girisButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.Location = new System.Drawing.Point(458, 305);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(75, 35);
            this.girisButton.TabIndex = 7;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // kayıtOlbutton
            // 
            this.kayıtOlbutton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtOlbutton.Location = new System.Drawing.Point(914, 12);
            this.kayıtOlbutton.Name = "kayıtOlbutton";
            this.kayıtOlbutton.Size = new System.Drawing.Size(116, 35);
            this.kayıtOlbutton.TabIndex = 8;
            this.kayıtOlbutton.Text = "KAYIT OL";
            this.kayıtOlbutton.UseVisualStyleBackColor = true;
            this.kayıtOlbutton.Click += new System.EventHandler(this.kayıtOlbutton_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1042, 404);
            this.Controls.Add(this.kayıtOlbutton);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciAdiText);
            this.Controls.Add(this.kullaniciAdiLabel);
            this.Controls.Add(this.logtitle2);
            this.Controls.Add(this.logtitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.Text = "PETNET GİRİŞ";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logtitle;
        private System.Windows.Forms.Label logtitle2;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Button kayıtOlbutton;
    }
}

