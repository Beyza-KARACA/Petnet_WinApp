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
    public partial class HOME : Form
    {
        public string name;
        public int userid;
        public HOME(Form f,string kullanici,int ID)
        {
            InitializeComponent();
            f.Close();
            name = kullanici;
            userid = ID;
        }

   private void kayipButton_Click(object sender, EventArgs e)
        {
            LOST l=new LOST(this,name, userid);
            l.Show();
        }

        private void evButton_Click(object sender, EventArgs e)
        {
            ADOPT a =new ADOPT(this,name, userid);
            a.Show();
        }

        private void yeniKayitButton_Click(object sender, EventArgs e)
        {
            NEW n=new NEW(this,name, userid);
            n.Show();
        }


        private void HOME_Load(object sender, EventArgs e)
        {
            userButton.Text = name;
            if (name == "Ece" || name == "Beyza")
            {
                yonetımButton.Visible = true;
            }

        }

        private void cikisButtton_Click(object sender, EventArgs e)
        {
            LOGIN l=new LOGIN(this);
            l.Show();
            
        }

        private void yonetımButton_Click(object sender, EventArgs e)
        {
            ADMIN a=new ADMIN(this,name, userid);
            a.Show();
        }
    }
}
