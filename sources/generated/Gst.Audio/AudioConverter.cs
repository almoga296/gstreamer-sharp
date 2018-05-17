// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AudioConverter : IEquatable<AudioConverter> {


		public static Gst.Audio.AudioConverter Zero = new Gst.Audio.AudioConverter ();

		public static Gst.Audio.AudioConverter New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Audio.AudioConverter.Zero;
			return (Gst.Audio.AudioConverter) Marshal.PtrToStructure (raw, typeof (Gst.Audio.AudioConverter));
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_converter_new(int flags, IntPtr in_info, IntPtr out_info, IntPtr config);

		public static AudioConverter New(Gst.Audio.AudioConverterFlags flags, Gst.Audio.AudioInfo in_info, Gst.Audio.AudioInfo out_info, Gst.Structure config)
		{
			config.Owned = false;
			AudioConverter result = AudioConverter.New (gst_audio_converter_new((int) flags, in_info == null ? IntPtr.Zero : in_info.Handle, out_info == null ? IntPtr.Zero : out_info.Handle, config == null ? IntPtr.Zero : config.Handle));
			return result;
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_converter_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_audio_converter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_converter_get_config(IntPtr raw, out int in_rate, out int out_rate);

		public Gst.Structure GetConfig(out int in_rate, out int out_rate) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_audio_converter_get_config(this_as_native, out in_rate, out out_rate);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_converter_get_in_frames(IntPtr raw, UIntPtr out_frames);

		public ulong GetInFrames(ulong out_frames) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			UIntPtr raw_ret = gst_audio_converter_get_in_frames(this_as_native, new UIntPtr (out_frames));
			ulong ret = (ulong) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_converter_get_max_latency(IntPtr raw);

		public ulong MaxLatency { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				UIntPtr raw_ret = gst_audio_converter_get_max_latency(this_as_native);
				ulong ret = (ulong) raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_audio_converter_get_out_frames(IntPtr raw, UIntPtr in_frames);

		public ulong GetOutFrames(ulong in_frames) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			UIntPtr raw_ret = gst_audio_converter_get_out_frames(this_as_native, new UIntPtr (in_frames));
			ulong ret = (ulong) raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_converter_reset(IntPtr raw);

		public void Reset() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_audio_converter_reset(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_audio_converter_samples(IntPtr raw, int flags, IntPtr in_param, UIntPtr in_frames, IntPtr out_param, UIntPtr out_frames);

		public bool Samples(Gst.Audio.AudioConverterFlags flags, IntPtr in_param, ulong in_frames, IntPtr out_param, ulong out_frames) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_audio_converter_samples(this_as_native, (int) flags, in_param, new UIntPtr (in_frames), out_param, new UIntPtr (out_frames));
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		public bool Samples(Gst.Audio.AudioConverterFlags flags, ulong in_frames, ulong out_frames) {
			return Samples (flags, IntPtr.Zero, in_frames, IntPtr.Zero, out_frames);
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_audio_converter_supports_inplace(IntPtr raw);

		public bool SupportsInplace() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_audio_converter_supports_inplace(this_as_native);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_audio_converter_update_config(IntPtr raw, int in_rate, int out_rate, IntPtr config);

		public bool UpdateConfig(int in_rate, int out_rate, Gst.Structure config) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			config.Owned = false;
			bool raw_ret = gst_audio_converter_update_config(this_as_native, in_rate, out_rate, config == null ? IntPtr.Zero : config.Handle);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		public bool UpdateConfig(int in_rate, int out_rate) {
			return UpdateConfig (in_rate, out_rate, null);
		}

		static void ReadNative (IntPtr native, ref Gst.Audio.AudioConverter target)
		{
			target = New (native);
		}

		public bool Equals (AudioConverter other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is AudioConverter && Equals ((AudioConverter) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Audio.AudioConverter boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Audio.AudioConverter.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Audio.AudioConverter (GLib.Value val)
		{
			return (Gst.Audio.AudioConverter) val.Val;
		}
#endregion
	}
}
