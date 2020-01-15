using System;
using UIKit;

namespace RomanNumeralConverterWorking
{
    public partial class ViewController : UIViewController
    {
        const string CLEAR = "";
        const string ERROR = "ERROR";

        partial void BtnConvertNumber_TouchUpInside(UIButton sender)
        {
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            btnConvertNumber.TouchUpInside += (object sender, EventArgs e) =>             {                 txtDigit.ResignFirstResponder(); //Get rid of the keyboard
                ProcessResponse(
                    NumberConverter.ConversionResponse(
                        NumberConverter.ConvertNumberToNumeral(txtDigit.Text)), txtDigit, lblError); //Set text field to converted numeral             } ;

            btnConvertNumeral.TouchUpInside += (object sender, EventArgs e) =>
            {
                txtDigit.ResignFirstResponder(); //Get rid of the keyboard
                ProcessResponse(
                    NumberConverter.ConversionResponse(
                        NumberConverter.ConvertNumeralToNumber(txtDigit.Text)), txtDigit, lblError); //Set text field to converted numeral
            };              //Quick clear the text field             btnClear.TouchUpInside += (object sender, EventArgs e) =>             {                 ClearText();             } ;
        }

        public void ProcessResponse(string response, UITextField txt, UILabel lbl)
        {
            if (response.Contains(ERROR))
            {
                lbl.Text = response;
            }
            else
            {
                txt.Text = response;
                ClearErrorLabel();
            }
        }

        //Clear text field
        public void ClearText()
        {
            txtDigit.Text = CLEAR;
        }

        //Clear Error Label
        public void ClearErrorLabel()
        {
            lblError.Text = CLEAR;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
