namespace PROJE_B161210367_BeyzaKARACA_32B
{
    partial class ADOPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADOPT));
            this.sahiplenmeButton = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.LinkLabel();
            this.hosLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.logtitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rehomeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pETNETDataSet = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSet();
            this.rehomeListTableAdapter = new PROJE_B161210367_BeyzaKARACA_32B.PETNETDataSetTableAdapters.RehomeListTableAdapter();
            this.yonetımButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehomeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sahiplenmeButton
            // 
            this.sahiplenmeButton.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sahiplenmeButton.Location = new System.Drawing.Point(388, 483);
            this.sahiplenmeButton.Name = "sahiplenmeButton";
            this.sahiplenmeButton.Size = new System.Drawing.Size(266, 40);
            this.sahiplenmeButton.TabIndex = 27;
            this.sahiplenmeButton.Text = "SAHİPLENMEK İSTİYORUM";
            this.sahiplenmeButton.UseVisualStyleBackColor = true;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.SlateBlue;
            this.title2.Location = new System.Drawing.Point(358, 78);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(347, 25);
            this.title2.TabIndex = 26;
            this.title2.Text = "EV ARAYAN ARKADAŞLARIMIZ";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.userLabel.Location = new System.Drawing.Point(996, 19);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(37, 18);
            this.userLabel.TabIndex = 24;
            this.userLabel.TabStop = true;
            this.userLabel.Text = "jkhj";
            // 
            // hosLabel
            // 
            this.hosLabel.AutoSize = true;
            this.hosLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hosLabel.Location = new System.Drawing.Point(880, 19);
            this.hosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hosLabel.Name = "hosLabel";
            this.hosLabel.Size = new System.Drawing.Size(108, 18);
            this.hosLabel.TabIndex = 23;
            this.hosLabel.Text = "HOŞGELDİN ";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(12, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(103, 40);
            this.homeButton.TabIndex = 22;
            this.homeButton.Text = "ANA MENÜ";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logtitle
            // 
            this.logtitle.AutoSize = true;
            this.logtitle.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.logtitle.Location = new System.Drawing.Point(420, 4);
            this.logtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logtitle.Name = "logtitle";
            this.logtitle.Size = new System.Drawing.Size(223, 59);
            this.logtitle.TabIndex = 21;
            this.logtitle.Text = "PETNET";
            this.logtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rehomeListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 341);
            this.dataGridView1.TabIndex = 20;
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
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TÜR";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
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
            // rehomeListBindingSource
            // 
            this.rehomeListBindingSource.DataMember = "RehomeList";
            this.rehomeListBindingSource.DataSource = this.pETNETDataSet;
            // 
            // pETNETDataSet
            // 
            this.pETNETDataSet.DataSetName = "PETNETDataSet";
            this.pETNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rehomeListTableAdapter
            // 
            this.rehomeListTableAdapter.ClearBeforeFill = true;
            // 
            // yonetımButton
            // 
            this.yonetımButton.Location = new System.Drawing.Point(883, 40);
            this.yonetımButton.Name = "yonetımButton";
            this.yonetımButton.Size = new System.Drawing.Size(150, 33);
            this.yonetımButton.TabIndex = 28;
            this.yonetımButton.Text = "YÖNETİM EKRANI";
            this.yonetımButton.UseVisualStyleBackColor = true;
            this.yonetımButton.Visible = false;
            this.yonetımButton.Click += new System.EventHandler(this.yonetımButton_Click);
            // 
            // ADOPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1065, 539);
            this.Controls.Add(this.yonetımButton);
            this.Controls.Add(this.sahiplenmeButton);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.hosLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.logtitle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADOPT";
            this.Text = "PETNET EV ARAYAN ARKADAŞLARIMIZ";
            this.Load += new System.EventHandler(this.ADOPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehomeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETNETDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sahiplenmeButton;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.LinkLabel userLabel;
        private System.Windows.Forms.Label hosLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label logtitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PETNETDataSet pETNETDataSet;
        private System.Windows.Forms.BindingSource rehomeListBindingSource;
        private PETNETDataSetTableAdapters.RehomeListTableAdapter rehomeListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button yonetımButton;
    }
}