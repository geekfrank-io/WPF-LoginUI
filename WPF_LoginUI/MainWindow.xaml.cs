using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LoginUI
{

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        //LoginModel loginModel;

        LoginViewModel loginViewModel;
        public MainWindow()
        {
            InitializeComponent();
            //loginModel = new LoginModel();

            loginViewModel = new LoginViewModel(this);

            this.DataContext = loginViewModel;
            loginViewModel.Username = "87987";
            loginViewModel.Password = "236982y";
        }

        //private string username;
        //private string password;

        ////Property Binding
        //public string Username
        //{
        //    set
        //    {
        //        username = value;
        //        RaisePropertyChanged("Username");
        //    }
        //    get { return username; }
        //}
        //public string Password
        //{
        //    set
        //    {
        //        password = value;
        //        RaisePropertyChanged("Password");
        //    }
        //    get { return password; }
        //}


        ////实现接口
        //public event PropertyChangedEventHandler PropertyChanged;
        ////固定写法
        //private void RaisePropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //}





        //public class LoginModel : INotifyPropertyChanged
        //{
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    private void RaisePropertyChanged(string propertyName)
        //    {
        //        PropertyChangedEventHandler handler = PropertyChanged;
        //        if (handler != null)
        //            handler(this, new PropertyChangedEventArgs(propertyName));
        //    }

        //    private string username;
        //    private string password;

        //    //Property Binding
        //    public string Username
        //    {
        //        set
        //        {
        //            username = value;
        //            RaisePropertyChanged("Username");
        //        }
        //        get { return username; }
        //    }
        //    public string Password
        //    {
        //        set
        //        {
        //            password = value;
        //            RaisePropertyChanged("Password");
        //        }
        //        get { return password; }
        //    }

    }
}