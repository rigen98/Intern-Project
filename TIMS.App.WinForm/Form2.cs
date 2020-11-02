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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        SharedDelegate _sharedDelegate;
        public Form2()
        {
            InitializeComponent();
            _sharedDelegate = new SharedDelegate();
            Page2Next.Click += choosePageNext;
            Page2Back.Click += choosePageBack;

        }

        public void SetText(BmiCalculationResult bmiResult)
        {
            Page2Text.Text = bmiResult.Text;
            Page2Next.Text = bmiResult.button1Text;
            Page2Back.Text = bmiResult.button2Text;
        }

        public void choosePageNext(object sender, System.EventArgs e)
        {
            form3 = new Form3();
            form3.MdiParent = this.MdiParent; 
            form3.SetText(_sharedDelegate.GoToLastScreen());
            form3.Show();
            Close();

        }

        public void choosePageBack(object sender, System.EventArgs e)
        {
            form1 = new Form1();
            form1.MdiParent = this.MdiParent;
            form1.Show();
            Close();

        }
    }
}
