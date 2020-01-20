using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Threading;


namespace ShredShop
{
    
    public partial class ProductPg : Form
    {
        protected Database database;
        Bitmap volOn = Properties.Resources.volOn;
        Bitmap volOff = Properties.Resources.volOff;
        PictureBox pic = new PictureBox();
        WindowsMediaPlayer player;

        public ProductPg(Database database, WindowsMediaPlayer player)
        {
            this.database = database;
            this.player = player;

            InitializeComponent();
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            this.BackColor = Color.Transparent;
           
            volPicBox.Image = volOn;
            pic.Image = volOn;
        }

        private void volPicBox_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("clicked" + volPicBox.Image);
            if (pic.Image == volOn)
            {
              //  MessageBox.Show("on, turning off" + volPicBox.Image);
                player.controls.pause();
                volPicBox.Image = volOff;
                pic.Image = volPicBox.Image;
               // MessageBox.Show("done1");
            }
            else if (pic.Image == volOff)
            {
               // MessageBox.Show("off, turning on" + volPicBox.Image);
                player.controls.play();
                volPicBox.Image = volOn;
                pic.Image = volPicBox.Image;
              //  MessageBox.Show("done2");
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
//            MessageBox.Show("Go to sign up screen");
            new SignIn(database, player).ShowDialog();
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
//            MessageBox.Show("Go to register screen");
            new RegisterPg(database, player).ShowDialog();
            this.Close();
        }
    }
}
