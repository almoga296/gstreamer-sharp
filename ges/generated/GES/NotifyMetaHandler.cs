// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void NotifyMetaHandler(object o, NotifyMetaArgs args);

	public class NotifyMetaArgs : GLib.SignalArgs {
		public string Object{
			get {
				return (string) Args [0];
			}
		}

		public GLib.Value P0{
			get {
				return (GLib.Value) Args [1];
			}
		}

	}
}