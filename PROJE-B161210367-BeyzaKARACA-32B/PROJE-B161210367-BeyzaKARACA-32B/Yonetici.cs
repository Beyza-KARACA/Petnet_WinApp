using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_B161210367_BeyzaKARACA_32B
{
    public partial class ADMIN : Form
    {
        public string kullanici;
        public int userid;
        public ADMIN(Form f,string name,int ID)
        {
            InitializeComponent();
            f.Close();
            kullanici = name;
            userid = ID;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HOME h = new HOME(this, kullanici,userid);
            h.Show();
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pETNETDataSet3.YoneticiLost' table. You can move, or remove it, as needed.
            this.yoneticiLostTableAdapter.Fill(this.pETNETDataSet3.YoneticiLost);
            // TODO: This line of code loads data into the 'pETNETDataSet2.YoneticiRehome' table. You can move, or remove it, as needed.
            this.yoneticiRehomeTableAdapter.Fill(this.pETNETDataSet2.YoneticiRehome);

        }
    }
}
