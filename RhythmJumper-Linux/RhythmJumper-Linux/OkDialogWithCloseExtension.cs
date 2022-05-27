using System;
using Gtk;

namespace RhythmJumperLinux
{
	public class OkDialogWithCloseExtension
	{
		private MessageDialog d;

		public OkDialogWithCloseExtension (Window parentWindow, String text)
		{
			// https://stackoverflow.com/a/4432573
			d = new MessageDialog (parentWindow, DialogFlags.DestroyWithParent | DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, 
				text);
		}

		public void show() {
			try {
				d.Run ();
			}
			finally {
				if (d != null)
					d.Destroy ();
			}
		}
	}
}

