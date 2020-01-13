// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RomanNumeralConverterWorking
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
        UIKit.UIButton btnConvertNumeral { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblInstructions { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtDigit { get; set; }

        [Action ("BtnConvertNumber_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnConvertNumber_TouchUpInside (UIKit.UIButton sender);

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

            if (btnConvertNumeral != null) {
                btnConvertNumeral.Dispose ();
                btnConvertNumeral = null;
            }

            if (lblInstructions != null) {
                lblInstructions.Dispose ();
                lblInstructions = null;
            }

            if (txtDigit != null) {
                txtDigit.Dispose ();
                txtDigit = null;
            }
        }
    }
}