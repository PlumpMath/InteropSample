using System;
using System.Runtime.InteropServices;

namespace InteropTest
{
    [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
    public struct UserTestData
    {
        [MarshalAs(UnmanagedType.U1)]
        public bool boolData;
        [MarshalAs(UnmanagedType.U1)]
        public char charData;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string stringData;
        [MarshalAs(UnmanagedType.I4)]
        public int IntData;
    }

    class NativeModule
    {
        [DllImport("InteropNative.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Test(UserTestData data);
    }
}
