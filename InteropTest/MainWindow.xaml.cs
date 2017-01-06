using System;
using System.Windows;

namespace InteropTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public unsafe MainWindow()
        {
            InitializeComponent();

            UserTestData data = new UserTestData();
            data.boolData = true;
            data.charData = 'a';
            data.IntData = 10;

            byte* addr = (byte*)&data;

            Console.WriteLine("address: {0}", (byte*)&data.charData - addr);
            NativeModule.Test(data);
        }
    }
}
