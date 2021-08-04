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
    public partial class SIGNUP : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PETNET;Integrated Security=True;";
        public SIGNUP(Form f)
        {
            InitializeComponent();
            f.Close();
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void kayitButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KullaniciEkle"; //Stored Procedure' ümüzün ismi
            cmd.Parameters.Add("Kullanici_Name", SqlDbType.NVarChar, 10).Value = kullaniciAdiText.Text; //Stored procedure deki parametreler
            cmd.Parameters.Add("Password", SqlDbType.NVarChar, 50).Value = sifreText.Text;
            cmd.Parameters.Add("FullName", SqlDbType.NVarChar, 50).Value = isimSoyisimText.Text;
            cmd.Parameters.Add("Birth", SqlDbType.Date).Value = dogumTarihi.Value;
            cmd.Parameters.Add("Place", SqlDbType.NVarChar, 10).Value = sehirText.Text;
            cmd.Parameters.Add("EMail", SqlDbType.NVarChar, 50).Value = mailText.Text;
            cmd.Parameters.Add("RoleID", SqlDbType.Int).Value = 24;
            cmd.ExecuteNonQuery();
            con.Close();
            bilgilendirmeLabel.Visible = true;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            LOGIN l=new LOGIN(this);
            l.Show();
        }
    }
}
