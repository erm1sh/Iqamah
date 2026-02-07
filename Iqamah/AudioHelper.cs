using System;
using System.Runtime.InteropServices;

namespace Iqamah
{
    /// <summary>
    /// Windows Core Audio API ile sistem sesini susturma/açma.
    /// Namaz vakti geldiğinde bilgisayarı sessiz moda alır.
    /// </summary>
    internal static class AudioHelper
    {
        private static bool bizSusturduk = false;

        /// <summary>
        /// Bilgisayarı sessiz moda alır.
        /// Zaten sessizse tekrar dokunmaz.
        /// </summary>
        public static void Sustur()
        {
            try
            {
                if (!IsMuted())
                {
                    SetMute(true);
                    bizSusturduk = true;
                }
            }
            catch { /* Ses API erişilemezse sessizce geç */ }
        }

        /// <summary>
        /// Biz susturmuşsak sesi geri açar.
        /// Kullanıcı zaten kendisi susturmuşsa dokunmaz.
        /// </summary>
        public static void SesAc()
        {
            try
            {
                if (bizSusturduk)
                {
                    SetMute(false);
                    bizSusturduk = false;
                }
            }
            catch { }
        }

        private static bool IsMuted()
        {
            var volume = GetVolumeObject();
            if (volume == null) return false;

            bool muted;
            volume.GetMute(out muted);
            Marshal.ReleaseComObject(volume);
            return muted;
        }

        private static void SetMute(bool mute)
        {
            var volume = GetVolumeObject();
            if (volume == null) return;

            Guid guid = Guid.Empty;
            volume.SetMute(mute, ref guid);
            Marshal.ReleaseComObject(volume);
        }

        private static IAudioEndpointVolume GetVolumeObject()
        {
            try
            {
                var enumerator = (IMMDeviceEnumerator)new MMDeviceEnumeratorComObject();
                IMMDevice device;
                // eRender = 0, eMultimedia = 1
                enumerator.GetDefaultAudioEndpoint(0, 1, out device);
                Marshal.ReleaseComObject(enumerator);

                Guid iid = typeof(IAudioEndpointVolume).GUID;
                object obj;
                device.Activate(ref iid, 1, IntPtr.Zero, out obj);
                Marshal.ReleaseComObject(device);

                return (IAudioEndpointVolume)obj;
            }
            catch
            {
                return null;
            }
        }

        // ---- COM Interop tanımları (Windows Core Audio API) ----

        [ComImport, Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
        private class MMDeviceEnumeratorComObject { }

        [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDeviceEnumerator
        {
            int NotImpl_EnumAudioEndpoints();

            [PreserveSig]
            int GetDefaultAudioEndpoint(int dataFlow, int role, out IMMDevice endpoint);
        }

        [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDevice
        {
            [PreserveSig]
            int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams,
                [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
        }

        [Guid("5CDF2C82-841E-4546-9722-0CF74078229A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IAudioEndpointVolume
        {
            int RegisterControlChangeNotify(IntPtr pNotify);
            int UnregisterControlChangeNotify(IntPtr pNotify);
            int GetChannelCount(out int pnChannelCount);
            int SetMasterVolumeLevel(float fLevelDB, ref Guid pguidEventContext);
            int SetMasterVolumeLevelScalar(float fLevel, ref Guid pguidEventContext);
            int GetMasterVolumeLevel(out float pfLevelDB);
            int GetMasterVolumeLevelScalar(out float pfLevel);
            int SetChannelVolumeLevel(uint nChannel, float fLevelDB, ref Guid pguidEventContext);
            int SetChannelVolumeLevelScalar(uint nChannel, float fLevel, ref Guid pguidEventContext);
            int GetChannelVolumeLevel(uint nChannel, out float pfLevelDB);
            int GetChannelVolumeLevelScalar(uint nChannel, out float pfLevel);

            [PreserveSig]
            int SetMute([MarshalAs(UnmanagedType.Bool)] bool bMute, ref Guid pguidEventContext);

            [PreserveSig]
            int GetMute([MarshalAs(UnmanagedType.Bool)] out bool pbMute);
        }
    }
}

