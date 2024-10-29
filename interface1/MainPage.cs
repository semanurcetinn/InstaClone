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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog(); //form kapatılmadan diğer formun kullanılmasını engeller.
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxProfile, "Profile");
            toolTip1.SetToolTip(pictureBox5, "Like");
            toolTip1.SetToolTip(pictureBox2, "Direct");
            toolTip1.SetToolTip(pictureBox3, "Feed");
            toolTip1.SetToolTip(pictureBoxSearch, "Explore");
            toolTip1.SetToolTip(pictureBox9, "Home");
            toolTip1.SetToolTip(pictureBox1, "Instagram");
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

    }
}
