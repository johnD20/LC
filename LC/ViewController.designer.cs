// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace LC
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton detailsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoodButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton newButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightTextField { get; set; }

        [Action ("NewButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NewButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (detailsButton != null) {
                detailsButton.Dispose ();
                detailsButton = null;
            }

            if (GoodButton != null) {
                GoodButton.Dispose ();
                GoodButton = null;
            }

            if (heightTextField != null) {
                heightTextField.Dispose ();
                heightTextField = null;
            }

            if (newButton != null) {
                newButton.Dispose ();
                newButton = null;
            }

            if (weightTextField != null) {
                weightTextField.Dispose ();
                weightTextField = null;
            }
        }
    }
}