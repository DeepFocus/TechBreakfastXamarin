using System;
using MonoTouch.UIKit;

namespace TechBreakfastiPhone
{
	public class TableSource : UITableViewSource {

		protected string[] tableItems;
		protected string cellIdentifier = "TableCell";

		public TableSource (string[] items)
		{
			tableItems = items;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			// request a recycled cell to save memory
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			// if there are no cells to reuse, create a new one
			if (cell == null) 
			{
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			}

			cell.TextLabel.Text = tableItems[indexPath.Row];

			return cell;
		}
	}
}

