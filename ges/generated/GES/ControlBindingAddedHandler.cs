// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void ControlBindingAddedHandler(object o, ControlBindingAddedArgs args);

	public class ControlBindingAddedArgs : GLib.SignalArgs {
		public Gst.ControlBinding ControlBinding{
			get {
				return (Gst.ControlBinding) Args [0];
			}
		}

	}
}