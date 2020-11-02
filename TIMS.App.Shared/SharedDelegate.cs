using System;
using System.Collections.Generic;
using System.Text;
using TIMS.App.Mobile.Shared.Models;

namespace TIMS.App.Mobile.Shared
{
    class SharedDelegate
    {
        public Action<BmiCalculationResult> OnNotHealthy { get; set; }
        public Action<BmiCalculationResult> OnHealthy { get; set; }
        public NewPageModel newScreen()
        {
            var model = new NewPageModel();
            model.Text = "BMI Calculator";
            model.button1Text = "Next";
            model.button2Text = "Back";
            return model;

        }

        public BmiCalculationResult GoToLastScreen()
        {
            BmiCalculationResult bmiResult = new BmiCalculationResult();
            bmiResult.Text = "Thank you for filling the form.";
            bmiResult.button1Text = "Next";
            return bmiResult;
        }


        public void GoToNextScreen(double height, double weight)
        {
            var healthy = isBmiHealthy(height, weight);
            if (healthy)
            {
                OnHealthy?.Invoke(new BmiCalculationResult()
                {
                    Text = "You are healthy.",
                    button1Text = "Next",
                });
            }
            else
            {
                OnNotHealthy?.Invoke(new BmiCalculationResult()
                {
                    Text = "You are not healthy, please fill in form.",
                    button1Text = "Next",
                    button2Text = "Back",
                });
            }
        }

        public bool isBmiHealthy(double height = 0, double weight = 0)
        {
            double bmi = weight / height / height;
            return !(bmi <= 18.5) && !(bmi >= 24.9);
        }
    }
}
