// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void ControlBindingConvertNative(IntPtr binding, double src_value, IntPtr dest_value);

	internal class ControlBindingConvertInvoker {

		ControlBindingConvertNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ControlBindingConvertInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ControlBindingConvertInvoker (ControlBindingConvertNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ControlBindingConvertInvoker (ControlBindingConvertNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ControlBindingConvertInvoker (ControlBindingConvertNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.ControlBindingConvert Handler {
			get {
				return new Gst.ControlBindingConvert(InvokeNative);
			}
		}

		void InvokeNative (Gst.ControlBinding binding, double src_value, GLib.Value dest_value)
		{
			IntPtr native_dest_value = GLib.Marshaller.StructureToPtrAlloc (dest_value);
			native_cb (binding == null ? IntPtr.Zero : binding.Handle, src_value, native_dest_value);
			Marshal.FreeHGlobal (native_dest_value);
		}
	}

	internal class ControlBindingConvertWrapper {

		public void NativeCallback (IntPtr binding, double src_value, IntPtr dest_value)
		{
			try {
				managed (GLib.Object.GetObject(binding) as Gst.ControlBinding, src_value, (GLib.Value) Marshal.PtrToStructure (dest_value, typeof (GLib.Value)));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ControlBindingConvertNative NativeDelegate;
		Gst.ControlBindingConvert managed;

		public ControlBindingConvertWrapper (Gst.ControlBindingConvert managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ControlBindingConvertNative (NativeCallback);
		}

		public static Gst.ControlBindingConvert GetManagedDelegate (ControlBindingConvertNative native)
		{
			if (native == null)
				return null;
			ControlBindingConvertWrapper wrapper = (ControlBindingConvertWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
