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
    public partial class Payment : Form
    {
        protected Database database;
        WindowsMediaPlayer player;

        public Payment(Database database, WindowsMediaPlayer player)
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
        }
        public Payment()
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
