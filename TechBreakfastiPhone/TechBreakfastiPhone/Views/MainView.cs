using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace TechBreakfastiPhone
{
	public class MainView : UIView
	{
		private UITableView _table;
		private MainController _ctrl;

		public MainView (MainController ctrl) : base(new RectangleF (0, 0, 640, 1136))
		{
			_ctrl = ctrl;
			BackgroundColor = UIColor.Blue;
			_table = new UITableView (Bounds);
			_table.Source = new TableSource (_ctrl.GetNames());

			Add (_table);
		}
	}
}

