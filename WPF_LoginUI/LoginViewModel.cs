using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private LoginModel loginModel;
        MainWindow mainWindow;
        private LoginModel LoginModel
        {
            get
            {
                return loginModel;
            }
            set
            {
                loginModel = value;
                //RaisePropertyChanged("LoginModel");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //固定写法
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public LoginViewModel(MainWindow mainWindow)
        {
            LoginModel = new LoginModel();

            this.mainWindow = mainWindow;
        }


        public string Username
        {
            set
            {
                LoginModel.Username = value;
                RaisePropertyChanged("Username");
            }
            get { return LoginModel.Username; }
        }
        public string Password
        {
            set
            {
                LoginModel.Password = value;
                RaisePropertyChanged("Password");
            }
            get { return LoginModel.Password; }
        }

        private void Button_Click()
        {

            if (Username == "admin" && Password == "123456")
            {
                WindowShow w = new WindowShow();
                w.Show();

                //想办法获取当前打开的界面的实例
                mainWindow.Hide();
            }
            else
            {
                //MessageBox.Show("Wrong username or password!");
                //清空失败 //默认单向绑定？
                Username = "";
                Password = "";
                // loginViewModel.LoginModel = loginViewModel.LoginModel;
            }

        }
        bool CanLoginExecute()
        {
            return true;
        }

        //命令，随后绑定
        public ICommand LoginAction
        {
            get { return new RelayCammand(Button_Click, CanLoginExecute); }
        }
    }
}
