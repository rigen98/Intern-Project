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
    public partial class Form3 : Form
    {
        SharedDelegate _shared;
        Form4 form4;
        public Form3()
        {
            InitializeComponent();
            _shared = new SharedDelegate();
            Page3Next.Click += choosePageNext;
        }

        public void SetText(BmiCalculationResult bmiResult)
        {
            Page3Text.Text = bmiResult.Text;
            Page3Next.Text = bmiResult.button1Text;
        }

        public void choosePageNext(object sender, System.EventArgs e)
        {
                form4 = new Form4();
                form4.MdiParent = this.MdiParent;
                form4.Show();
                Close();

        }

        public void choosePageBack(object sender, System.EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.MdiParent = this.MdiParent;
            form2.Show();
            Close();

        }
    }
}
