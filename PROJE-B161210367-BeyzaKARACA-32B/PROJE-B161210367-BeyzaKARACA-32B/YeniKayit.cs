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
    public partial class NEW : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PETNET;Integrated Security=True;";
        public string kullanici;
        public int userid;
        public int typeid;
        public int secim;
        public NEW(Form f,string name,int ID)
        {
            InitializeComponent();
            f.Close();
            kullanici = name;
            userid = ID;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            HOME h = new HOME(this, kullanici,userid);
            h.Show();
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            if (türComboBox.SelectedText == "KEDİ")
            {
                typeid = 4;
            }
            else if (türComboBox.SelectedText == "KÖPEK")
            {
                typeid = 5;
            }
            else if (türComboBox.SelectedText == "KUŞ")
            {
                typeid = 7;
            }
            if (comboBox2.SelectedText == "KAYIP İLANI")
            {
                secim=0;
            }
            else if (türComboBox.SelectedText == "SAHİPLENDİRME İLANI")
            {
                secim=1;
            }
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AnimalEkle"; //Stored Procedure' ümüzün ismi
            cmd.Parameters.Add("TypeID", SqlDbType.Int).Value = typeid; //Stored procedure deki parametreler
            cmd.Parameters.Add("FullName", SqlDbType.NVarChar, 50).Value = isimText.Text; //Stored procedure deki parametreler
            cmd.Parameters.Add("Gender", SqlDbType.NChar, 10).Value = comboBox1.SelectedText; //Stored procedure deki parametreler
            cmd.Parameters.Add("Age", SqlDbType.Int).Value = textBox1.Text; //Stored procedure deki parametreler
            cmd.Parameters.Add("Kind", SqlDbType.NVarChar, 50).Value = cinsText.Text; //Stored procedure deki parametreler
            cmd.Parameters.Add("UserID", SqlDbType.Int).Value =userid; //Stored procedure deki parametreler
            cmd.Parameters.Add("Which", SqlDbType.Int).Value = secim;
            cmd.ExecuteNonQuery();
            con.Close();
            bilgilendirmeLabel.Visible = true;
        }
    }
}
