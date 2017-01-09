using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

namespace InteropTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UserTestData data = new UserTestData();
            data.stringData = "yes";
            data.charData = 'a';
            data.IntData = 10;
            
            NativeModule.Test(data);
        }
    }
}
