using System;
using UIKit;

namespace RomanNumeralConverterWorking
{
    public partial class ViewController : UIViewController
    {
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
                txtDigit.Text = NumberConverter.ConversionResponse(NumberConverter.ConvertNumberToNumeral(txtDigit.Text)); //Set text field to converted numeral             } ;

            btnConvertNumeral.TouchUpInside += (object sender, EventArgs e) =>
            {
                txtDigit.ResignFirstResponder(); //Get rid of the keyboard
                txtDigit.Text = NumberConverter.ConversionResponse(NumberConverter.ConvertNumeralToNumber(txtDigit.Text)); //Set text field to converted numeral
            };              //Quick clear the text field             btnClear.TouchUpInside += (object sender, EventArgs e) =>             {                 txtDigit.Text = "";             } ;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
