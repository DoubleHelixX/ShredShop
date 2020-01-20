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

namespace ShredShop
{
    public partial class Confirmation : Form
    {
        protected Database database;
        Random rand = new Random();
        public const string Alphabet =
        "0123456789abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        WindowsMediaPlayer player;

        public Confirmation(Database database, WindowsMediaPlayer player)
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
            ordernumLbl.Text = "Order Number: " + GenerateString(12);
        }
        public Confirmation()
            
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
            ordernumLbl.Text = "Order Number: " + GenerateString(12);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            return new string(chars);
        }
        private void OrdernumLbl_Click(object sender, EventArgs e)
        {

        }

        private void OrdernumLbl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
