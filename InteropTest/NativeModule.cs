using System.Runtime.InteropServices;

namespace InteropTest
{
    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct UserTestData
    {
        public bool boolData;
        public char charData;
        public int IntData;

    }

    class NativeModule
    {
        [DllImport("InteropNative.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Test(UserTestData data);
    }
}
