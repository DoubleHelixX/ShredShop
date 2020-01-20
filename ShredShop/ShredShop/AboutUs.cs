using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace ShredShop
{
    public partial class AboutUs : Form
    {
        protected Database database;
        WindowsMediaPlayer player;

        public AboutUs(Database database, WindowsMediaPlayer player) 
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
            // player.controls.play();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            //            MessageBox.Show("Logging out");
            new SignIn(database, player).ShowDialog();
            this.Close();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //            MessageBox.Show("Logging in");
            new ProductPg(database, player).ShowDialog();
            this.Close();
        }
    }
}
