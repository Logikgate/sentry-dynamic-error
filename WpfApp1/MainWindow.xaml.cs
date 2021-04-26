using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Use the file name to load the assembly into the current
            // application domain.
            //Assembly a = Assembly.LoadFrom(Path.Combine("../../../", "ClassLibrary1", "bin","Debug","ClassLibrary1.dll"));
            Assembly a = Assembly.Load("ClassLibrary1");

            // Get the type to use.
            Type myType = a.GetType("ClassLibrary1.Class1");
            // Get the method to call.
            // MethodInfo myMethod = myType.GetMethod("MethodA");
            // Create an instance.
            object obj = Activator.CreateInstance(myType);
            // Execute the method.
            // myMethod.Invoke(obj, null);
        }
    }
}
