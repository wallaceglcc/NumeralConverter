using System;
using UIKit;

namespace RomanNumeralConverterWorking
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            btnConvertNumber.TouchUpInside += (object sender, EventArgs e) =>             {                 string convertedNumeral = NumberConverter.ConvertNumberToNumeral(txtDigit.Text); //Convert whatever is in the text field                  txtDigit.ResignFirstResponder(); //Get rid of the keyboard                  if (convertedNumeral != "") //Check if something was entered                 {                     if (convertedNumeral != "NN") //Check if it was a number                     {                         if (convertedNumeral != "OR") //Check if it was 1-10                         {                             txtDigit.Text = convertedNumeral; //Set text field to converted numeral                         }                         else txtDigit.Text = "Number must be 1-10";                     }                     else txtDigit.Text = "Entry must be a number 1-10";                 }                 else txtDigit.Text = "Enter a number 1-10";             } ;              //Quick clear the text field             btnClear.TouchUpInside += (object sender, EventArgs e) =>             {                 txtDigit.Text = "";             } ;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
