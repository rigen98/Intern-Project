using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMS.App.Mobile.Shared;
using TIMS.App.Mobile.Shared.Models;

namespace TIMS.App.WinForm
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
            Form1 form4 = new Form1();
            form4.MdiParent = this;
            form4.Show();
        }

    }
}
