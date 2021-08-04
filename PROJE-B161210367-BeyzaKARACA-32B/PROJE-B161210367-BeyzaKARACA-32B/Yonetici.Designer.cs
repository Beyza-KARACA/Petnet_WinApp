namespace PROJE_B161210367_BeyzaKARACA_32B
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.title3 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.logtitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiRehomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pETNETDataSet2 = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSet2();
            this.title2 = new System.Windows.Forms.Label();
            this.title4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kullaniciNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiLostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pETNETDataSet3 = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSet3();
            this.yoneticiRehomeTableAdapter = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSet2TableAdapters.YoneticiRehomeTableAdapter();
            this.yoneticiLostTableAdapter = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSet3TableAdapters.YoneticiLostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiRehomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiLostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.ForeColor = System.Drawing.Color.SlateBlue;
            this.title3.Location = new System.Drawing.Point(313, 106);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(347, 25);
            this.title3.TabIndex = 33;
            this.title3.Text = "EV ARAYAN ARKADAŞLARIMIZ";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(8, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(103, 40);
            this.homeButton.TabIndex = 29;
            this.homeButton.Text = "ANA MENÜ";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logtitle
            // 
            this.logtitle.AutoSize = true;
            this.logtitle.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logtitle.Location = new System.Drawing.Point(194, 11);
            this.logtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logtitle.Name = "logtitle";
            this.logtitle.Size = new System.Drawing.Size(685, 59);
            this.logtitle.TabIndex = 28;
            this.logtitle.Text = "PETNET YÖNETİM EKRANI";
            this.logtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoneticiRehomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 187);
            this.dataGridView1.TabIndex = 27;
            // 
            // kullaniciNameDataGridViewTextBoxColumn
            // 
            this.kullaniciNameDataGridViewTextBoxColumn.DataPropertyName = "Kullanici_Name";
            this.kullaniciNameDataGridViewTextBoxColumn.HeaderText = "EKLEYEN";
            this.kullaniciNameDataGridViewTextBoxColumn.Name = "kullaniciNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "MAIL";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "İSİM";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "YAŞ";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "CİNSİYET";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "CİNS";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "TAG";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // yoneticiRehomeBindingSource
            // 
            this.yoneticiRehomeBindingSource.DataMember = "YoneticiRehome";
            this.yoneticiRehomeBindingSource.DataSource = this.pETNETDataSet2;
            // 
            // pETNETDataSet2
            // 
            this.pETNETDataSet2.DataSetName = "PETNETDataSet2";
            this.pETNETDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.title2.Location = new System.Drawing.Point(371, 66);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(212, 25);
            this.title2.TabIndex = 34;
            this.title2.Text = "GÜNCELLEMELER";
            // 
            // title4
            // 
            this.title4.AutoSize = true;
            this.title4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title4.ForeColor = System.Drawing.Color.SlateBlue;
            this.title4.Location = new System.Drawing.Point(350, 380);
            this.title4.Name = "title4";
            this.title4.Size = new System.Drawing.Size(289, 25);
            this.title4.TabIndex = 38;
            this.title4.Text = "KAYIP ARKADAŞLARIMIZ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciNameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.genderDataGridViewTextBoxColumn1,
            this.kindDataGridViewTextBoxColumn1,
            this.explanationDataGridViewTextBoxColumn1,
            this.tagDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.yoneticiLostBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 408);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(840, 187);
            this.dataGridView2.TabIndex = 37;
            // 
            // kullaniciNameDataGridViewTextBoxColumn1
            // 
            this.kullaniciNameDataGridViewTextBoxColumn1.DataPropertyName = "Kullanici_Name";
            this.kullaniciNameDataGridViewTextBoxColumn1.HeaderText = "EKLEYEN";
            this.kullaniciNameDataGridViewTextBoxColumn1.Name = "kullaniciNameDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "MAIL";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "İSİM";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "YAŞ";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "CİNSİYET";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            // 
            // kindDataGridViewTextBoxColumn1
            // 
            this.kindDataGridViewTextBoxColumn1.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn1.HeaderText = "CİNS";
            this.kindDataGridViewTextBoxColumn1.Name = "kindDataGridViewTextBoxColumn1";
            // 
            // explanationDataGridViewTextBoxColumn1
            // 
            this.explanationDataGridViewTextBoxColumn1.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn1.HeaderText = "AÇIKLAMA";
            this.explanationDataGridViewTextBoxColumn1.Name = "explanationDataGridViewTextBoxColumn1";
            // 
            // tagDataGridViewTextBoxColumn1
            // 
            this.tagDataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn1.HeaderText = "TAG";
            this.tagDataGridViewTextBoxColumn1.Name = "tagDataGridViewTextBoxColumn1";
            // 
            // yoneticiLostBindingSource
            // 
            this.yoneticiLostBindingSource.DataMember = "YoneticiLost";
            this.yoneticiLostBindingSource.DataSource = this.pETNETDataSet3;
            // 
            // pETNETDataSet3
            // 
            this.pETNETDataSet3.DataSetName = "PETNETDataSet3";
            this.pETNETDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiRehomeTableAdapter
            // 
            this.yoneticiRehomeTableAdapter.ClearBeforeFill = true;
            // 
            // yoneticiLostTableAdapter
            // 
            this.yoneticiLostTableAdapter.ClearBeforeFill = true;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1070, 658);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.logtitle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "PETNET YÖNETİM";
            this.Load += new System.EventHandler(this.ADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiRehomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiLostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label logtitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PETNETDataSet2 pETNETDataSet2;
        private System.Windows.Forms.BindingSource yoneticiRehomeBindingSource;
        private PETNETDataSet2TableAdapters.YoneticiRehomeTableAdapter yoneticiRehomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private PETNETDataSet3 pETNETDataSet3;
        private System.Windows.Forms.BindingSource yoneticiLostBindingSource;
        private PETNETDataSet3TableAdapters.YoneticiLostTableAdapter yoneticiLostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn1;
    }
}