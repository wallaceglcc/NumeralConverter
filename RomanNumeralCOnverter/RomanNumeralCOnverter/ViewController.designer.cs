// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RomanNumeralConverter
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnClear { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnConvertNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbInstructions { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtDigit { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnClear != null) {
                btnClear.Dispose ();
                btnClear = null;
            }

            if (btnConvertNumber != null) {
                btnConvertNumber.Dispose ();
                btnConvertNumber = null;
            }

            if (lbInstructions != null) {
                lbInstructions.Dispose ();
                lbInstructions = null;
            }

            if (txtDigit != null) {
                txtDigit.Dispose ();
                txtDigit = null;
            }
        }
    }
}