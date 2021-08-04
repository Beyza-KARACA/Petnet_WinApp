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
    public partial class LOGIN : Form
    {
        public string kullaniciAdi;
        public int ID;

        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PETNET;Integrated Security=True;";

        public LOGIN(Form f)
        {
            InitializeComponent();
            f.Close();
        }
        public LOGIN()
        {
            InitializeComponent();
            
        }

        private void kayıtOlbutton_Click(object sender, EventArgs e)
        {
           SIGNUP sign=new SIGNUP(this);
            sign.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiText.Text == "" || sifreText.Text == "")
            {
                MessageBox.Show("BOŞ BIRAKMAYINIZ");
                return;
            }
            try
            {
                
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Kullanici1 where Kullanici_Name=@Kullanici_Name and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Kullanici_Name", kullaniciAdiText.Text);
                cmd.Parameters.AddWithValue("@password",sifreText.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
             
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                   kullaniciAdi = kullaniciAdiText.Text;

                    IDBUL(kullaniciAdi);
                    HOME h = new HOME(this,kullaniciAdi,ID);
                   h.Show();    
                }
                else
                {
                    MessageBox.Show("GİRİŞ BAŞARISIZ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void IDBUL(string name)
        {
            if (kullaniciAdi == "Beyza")
            {
                ID = 1;
            }
            else if (kullaniciAdi == "Ece")
            {
                ID = 2;
            }
            else if (kullaniciAdi == "Zeynep")
            {
                ID = 3;
            }
        }
    }
    }

