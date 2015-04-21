
// This file has been generated by the GUI designer. Do not modify.
namespace MonoGame.Tools.Pipeline
{
	public partial class ColorPickerDialog
	{
		private global::Gtk.ColorSelection colorselection1;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoGame.Tools.Pipeline.ColorPickerDialog
			this.Name = "MonoGame.Tools.Pipeline.ColorPickerDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Color Picker");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoGame.Tools.Pipeline.ColorPickerDialog.VBox
            #if GTK2
			global::Gtk.VBox w1 = this.VBox;
            #elif GTK3
            global::Gtk.Box w1 = this.ContentArea;
            #endif
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.colorselection1 = new global::Gtk.ColorSelection ();
			this.colorselection1.Name = "colorselection1";
			this.colorselection1.HasPalette = true;
			this.colorselection1.HasOpacityControl = true;
			w1.Add (this.colorselection1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.colorselection1]));
			w2.Position = 0;
			// Internal child MonoGame.Tools.Pipeline.ColorPickerDialog.ActionArea
            #if GTK2
			global::Gtk.HButtonBox w3 = this.ActionArea;
            #elif GTK3
            global::Gtk.ButtonBox w3 = this.ActionArea;
            #endif
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonCancel]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w3.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3 [this.buttonOk]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 511;
			this.DefaultHeight = 334;
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
