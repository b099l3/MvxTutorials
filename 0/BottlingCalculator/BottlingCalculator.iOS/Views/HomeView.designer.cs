// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BottlingCalculator.iOS.Views
{
	[Register ("HomeView")]
	partial class HomeView
	{
		[Outlet]
		UIKit.UILabel BeerBottlesLabel { get; set; }

		[Outlet]
		UIKit.UITextField BeerInputTextField { get; set; }

		[Outlet]
		UIKit.UILabel KegsLabel { get; set; }

		[Outlet]
		UIKit.UILabel PintsLabel { get; set; }

		[Outlet]
		UIKit.UILabel WineBottlesLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BeerInputTextField != null) {
				BeerInputTextField.Dispose ();
				BeerInputTextField = null;
			}

			if (BeerBottlesLabel != null) {
				BeerBottlesLabel.Dispose ();
				BeerBottlesLabel = null;
			}

			if (PintsLabel != null) {
				PintsLabel.Dispose ();
				PintsLabel = null;
			}

			if (WineBottlesLabel != null) {
				WineBottlesLabel.Dispose ();
				WineBottlesLabel = null;
			}

			if (KegsLabel != null) {
				KegsLabel.Dispose ();
				KegsLabel = null;
			}
		}
	}
}
