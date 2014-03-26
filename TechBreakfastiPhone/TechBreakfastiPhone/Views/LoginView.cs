using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace TechBreakfastiPhone
{
	public class LoginView : UIView
	{
		private MainController _ctrl;
		private UITextField _textUser;
		private UITextField _textPw;

		public LoginView (MainController ctrl) : base(new RectangleF (0, 0, 640, 1136))
		{
			_ctrl = ctrl;

			BackgroundColor = UIColor.Orange;

			var lblUser = new UILabel (new RectangleF (20, 50, 250, 30));
			lblUser.TextColor = UIColor.Black;
			lblUser.Text = "Username: ";

			var lblPass = new UILabel (new RectangleF (20, 100, 250, 30));
			lblPass.TextColor = UIColor.Black;
			lblPass.Text = "Password: ";

			_textUser = new UITextField (new RectangleF (120, 50, 150, 30));
			_textUser.BackgroundColor = UIColor.White;

			_textPw = new UITextField(new RectangleF (120, 100, 150, 30));
			_textPw.BackgroundColor = UIColor.White;
			_textPw.SecureTextEntry = true;

			var button = new UIButton (UIButtonType.System);
			button.SetTitle ("Login", UIControlState.Normal);
			button.Layer.BorderWidth = 1;
			button.Layer.CornerRadius = 4;
			button.Layer.BorderColor = UIColor.Black.CGColor;
			button.TintColor = UIColor.Brown;
			button.Frame = new RectangleF(20, 150, 200, 30);

			button.TouchUpInside += ProcessLogin;;

			Add (lblUser);
			Add (_textUser);
			Add (lblPass);
			Add (_textPw);
			Add (button);
		}
			
		void ProcessLogin (object sender, EventArgs e)
		{
			var user = _textUser.Text;
			var pass = _textPw.Text;

			if (!_ctrl.IsValidLogin (user, pass)) {
				var alertView = new UIAlertView ("Error!", "Invalid login, please try again", null, "Ok", null);
				alertView.Show ();
			} 
			else 
			{
				_ctrl.ShowMainScreen ();
			}
		}
	}
}

