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

namespace LC
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView bmiDetailLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiNewDetailLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bmiDetailLabel != null) {
                bmiDetailLabel.Dispose ();
                bmiDetailLabel = null;
            }

            if (bmiNewDetailLabel != null) {
                bmiNewDetailLabel.Dispose ();
                bmiNewDetailLabel = null;
            }
        }
    }
}