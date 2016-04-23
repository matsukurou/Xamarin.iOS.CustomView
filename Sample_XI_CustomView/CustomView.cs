using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;

namespace Sample_XI_CustomView
{
	//[DesignTimeVisible (true)]
	partial class CustomView : UIView
	{
		public CustomView (IntPtr handle) : base (handle)
		{
		}

		public CustomView () : base ()
		{
			Initialize ();
		}

		public override void AwakeFromNib()
		{
			Initialize ();
		}

		void Initialize ()
		{
			UIView view = null;
			// CustomViewの読み込み
			var array = NSBundle.MainBundle.LoadNib ("CustomView", this, null);
			for (nuint i = 0; i < array.Count; i++) {
				view = Runtime.GetNSObject (array.ValueAt (i)) as UIView;
				if (view != null)
					break;
			}
			AddSubview (view);

			//Console.WriteLine (MyLabel.Text);
		}
	}
}
