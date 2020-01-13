using Foundation;
using System;
using UIKit;

namespace RomanNumeralConverter
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            string convertedNumeral = ""; //To hold returned numeral

            btnConvertNumber.TouchUpInside += (object sender, EventArgs e) =>
            {
                convertedNumeral = NumberConverter.ConvertNumberToNumeral(txtDigit); //Convert whatever is in the text field

                txtDigit.ResignFirstResponder(); //Get rid of the keyboard

                if (convertedNumeral != "") //Check if something was entered
                {
                    if (convertedNumeral != "NN") //Check if it was a number
                    {
                        if (convertedNumeral != "OR") //Check if it was 1-10
                        {
                            txtDigit.Text = convertedNumeral; //Set text field to converted numeral
                        }
                        else txtDigit.Text = "Number must be 1-10";
                    }
                    else txtDigit.Text = "Entry must be a number 1-10";
                }
                else txtDigit.Text = "Enter a number 1-10";
            };

            //Quick clear the text field
            btnClear.TouchUpInside += (object sender, EventArgs e) =>
            {
                txtDigit.Text = "";
            };
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}