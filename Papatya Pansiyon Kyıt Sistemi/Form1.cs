using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Papatya_Pansiyon_Kyıt_Sistemi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2GCN52O\\SQLEXPRESS01;Initial Catalog=PapatyaPansiyon;Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullanıcıAd.Text == "admin" && TxtSifre.Text == "12345")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
