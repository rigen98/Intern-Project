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
    public partial class Form4 : Form
    {
        SharedDelegate _shared;
        Form2 form2;
        Form3 form3;
        public Form4()
        {
            InitializeComponent();
            _shared = new SharedDelegate();
            var newScreenModel = _shared.newScreen();
            Page1Text.Text = newScreenModel?.Text;
            Page1Button.Text = newScreenModel?.button1Text;
            Page1Button.Click += Page1Button_Click;
            _shared.OnHealthy += (bmiResult) =>
            {
                form3 = new Form3();
                form3.MdiParent = this.MdiParent;
                form3.SetText(bmiResult);
                form3.Show();
                Hide();
            };
            _shared.OnNotHealthy += (bmiResult) =>
            {
                form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.SetText(bmiResult);
                form2.Show();
                Hide();
                
            };


        }

        private void Page1Button_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            _shared.GoToNextScreen(height, weight);


        }
    }
}
