using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class RelayCammand : System.Windows.Input.ICommand
    {

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }
        public bool CanExecute(object parameter)
        {

            //_canExecute没有实例化，直接执行
            if (_canExecute == null)
            {
                return true;
            }

            //不为空，返回函数结果
            return _canExecute();
        }

        public void Execute(object parameter)
        {
           _execute();
        }

        //命令能否执行
        readonly Func<bool> _canExecute;
        //命令需要执行的方法
        readonly Action _execute;

        public RelayCammand(Action action, Func<bool> canExecute)
        {
            _canExecute = canExecute;
            _execute = action;
        }
    }
}
