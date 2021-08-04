using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_B161210367_BeyzaKARACA_32B
{
    public partial class LOST : Form
    {
        public string kullanici;
        public int userid;
        public LOST(Form f,string name,int ID)
        {
            InitializeComponent();
            f.Close();
            kullanici = name;
            userid = ID;
        }
       
    private void LOST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pETNETDataSet1.LostList' table. You can move, or remove it, as needed.
            this.lostListTableAdapter.Fill(this.pETNETDataSet1.LostList);    
            // TODO: This line of code loads data into the 'pETNETDataSet2.LostList' table. You can move, or remove it, as needed.
            userLabel.Text = kullanici;
           if (kullanici == "Ece" || kullanici == "Beyza")
            {
                yonetımButton.Visible = true;
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HOME h = new HOME(this, kullanici,userid);
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yonetımButton_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN(this, kullanici, userid);
            a.Show();
        }
    }
}
