//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MovieLand.Views
//{
//    public partial class Register : Form
//    {
//        public Register()
//        {
//            InitializeComponent();
//            this.WindowState = FormWindowState.Maximized;
//        }

//        private void Register_Load(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void btn_Register_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(tb_Username.Text) ||
//                string.IsNullOrWhiteSpace(tb_Password.Text) ||
//                string.IsNullOrWhiteSpace(tb_Email.Text) ||
//                string.IsNullOrWhiteSpace(tb_PasswordConfirm.Text))
//            {
//                MessageBox.Show("Semua field harus diisi!");
//                return;
//            }

//            if (tb_Password.Text != tb_PasswordConfirm.Text)
//            {
//                MessageBox.Show("Password tidak cocok!");
//                return;
//            }

//            var context = new AkunContext();
//            if (context.UsernameExists(tb_Username.Text))
//            {
//                MessageBox.Show("Username sudah tidak tersedia!");
//                return;
//            }
//            if (context.EmailExists(tb_Email.Text))
//            {
//                MessageBox.Show("Email sudah digunakan!");
//                return;
//            }

//            if (DataAkun == null) DataAkun = new Akun();
//            DataAkun.username = tb_Username.Text;
//            DataAkun.password = tb_Password.Text;
//            DataAkun.email = tb_Email.Text;

//            bool success = context.Insert(DataAkun);
//            if (success)
//            {
//                MessageBox.Show("Registrasi berhasil!");
//                this.Close();
//            }
//            else
//            {
//                MessageBox.Show("Registrasi gagal. Silakan coba lagi.");
//            }
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
