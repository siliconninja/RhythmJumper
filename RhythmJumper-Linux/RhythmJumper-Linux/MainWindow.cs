using System;
using Gtk;
// https://stackoverflow.com/a/31324482
using RhythmJumperLinux;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		RhythmJumperLinux.OkDialogWithCloseExtension dialog = new RhythmJumperLinux.OkDialogWithCloseExtension (this,
			                                                      "Hi there Linux user! You have found the Golden Easter Egg, seriously! You set up " + Environment.NewLine +
			                                                      "your own Linux box and found out about this Linux edition, which is quite an accomplishment!" + Environment.NewLine +
			                                                      ":) Best regards, siliconninja");
		dialog.show ();
	}
}
