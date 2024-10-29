using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textBox1 içerik değişikliği olduğunda yapılacak işlemler.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // groupBox1 üzerine girildiğinde yapılacak işlemler.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kayıt Başarılı!");
                this.Close();

                //Anasayfayı açmak için ve mevcut formu kapatır.
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // Kullanıcı tıkladığında eğer placeholder metni varsa metni sil
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Kullanıcı metin kutusunu boş bırakarak çıktığında placeholder geri gelsin
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Kullanıcı Adı";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Şifre";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
