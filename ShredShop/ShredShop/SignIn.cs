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
    public partial class SignIn : Form
    {
        protected Database database;
        Bitmap volOn = Properties.Resources.volOn;
        Bitmap volOff = Properties.Resources.volOff;
        PictureBox pic = new PictureBox();
        WindowsMediaPlayer player;

        public SignIn(Database database, WindowsMediaPlayer player)
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            this.BackColor = Color.Transparent;
           
            volPicBox.Image = volOn;
            pic.Image = volOn;
        }

        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
//            MessageBox.Show("Go to register screen");
            new RegisterPg(database, player).ShowDialog();
            this.Close();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            /*
             * TODO: PSEUDOCODE
             * 
             * if can log in with username and password
             *     save login information
             *     show product screen
             * otherwise
             *     show message INVALID!
             */

            if (database.TryLogin(usernameTxt.Text.ToString(), passwordTxt.Text.ToString())) 
            { 
            this.Hide();
            //            MessageBox.Show("LOGGING IN ");
            new ProductPg(database, player).ShowDialog();
            this.Close();
             }
            else
            MessageBox.Show("Error Wrong Credentials : Try again");
        }


        private void ForgotPassLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
//            MessageBox.Show("Forgot Pass screen ");
            new ForgotPassword(database, player).ShowDialog();
            this.Close();
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

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmation c = new Confirmation();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
