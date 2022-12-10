namespace DoAnGiuaKy.GUI
{
	// Use this class instead of Button class in order to remove the annoying blue focus border.
	public class NoFocusCueButton : System.Windows.Forms.Button
	{
		public NoFocusCueButton()
		{
			SetStyle(System.Windows.Forms.ControlStyles.Selectable, false);
		}

		protected override bool ShowFocusCues
		{
			get
			{
				return false;
			}
		}
	}
}
