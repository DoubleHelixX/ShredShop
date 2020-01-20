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

    public partial class ForgotPassword : Form
    {
        protected Database database;
        WindowsMediaPlayer player;

        public ForgotPassword(Database database, WindowsMediaPlayer player)
        {
            InitializeComponent();
            this.database = database;
            this.player = player;
        }
    }
}
