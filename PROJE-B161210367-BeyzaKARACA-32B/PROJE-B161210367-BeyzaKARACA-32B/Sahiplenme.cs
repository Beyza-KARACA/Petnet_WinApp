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
    public partial class ADOPT : Form
    {
        public string kullanici;
        public int userid;
        public ADOPT(Form f,string name,int ID)
        {
            InitializeComponent();
            f.Close();
            kullanici = name;
            userid = ID;
        }
      
        private void ADOPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pETNETDataSet.RehomeList' table. You can move, or remove it, as needed.
            this.rehomeListTableAdapter.Fill(this.pETNETDataSet.RehomeList);
            userLabel.Text = kullanici;
          
            if (kullanici == "Ece" || kullanici == "Beyza")
            {
                yonetımButton.Visible = true;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HOME h=new HOME(this,kullanici,userid);
            h.Show();
        }

        private void yonetımButton_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN(this, kullanici, userid);
            a.Show();
        }
    }
}
