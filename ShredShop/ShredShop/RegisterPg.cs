using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;


namespace ShredShop
{
    public partial class RegisterPg : Form
    {
        protected Database database;
        Bitmap volOn = Properties.Resources.volOn;
        Bitmap volOff = Properties.Resources.volOff;
        PictureBox pic = new PictureBox();
        WindowsMediaPlayer player;

        public RegisterPg(Database database, WindowsMediaPlayer player)
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

        private void signUpLbl_Click(object sender, EventArgs e)
        {
            database.DoRegister(usernameTxt.Text, passwordTxt.Text, textBox1.Text);
        }
    }
}
