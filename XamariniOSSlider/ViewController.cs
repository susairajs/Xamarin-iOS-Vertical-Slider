using System;
using UIKit;
using CoreGraphics;
using static System.Math;

namespace XamariniOSSlider
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


			slider.MinValue= 1;
			slider.MaxValue = 10;
			slider.Value = 1;
			slider.Transform = CGAffineTransform.MakeRotation((float)PI / 2);

			slider.ValueChanged += (object sender, EventArgs e) => { lblValue.Text = slider.Value.ToString();};


			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
