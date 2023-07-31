using MVVMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Command.Wizard
{
    internal class FirstStepViewModel : MVVMCViewModel<WizardController>
    {

        private string computerName = "";
        public string ComputerName
        {
            get
            {
                return computerName;
            }
            set
            {
                computerName = value;
                OnPropertyChanged();
            }
        }

        internal void HandleComputerNameTextChanged(string text)
        {
            ComputerName = text;
            TestCommand.RaiseCanExecuteChanged();
        }

        public ICommand _testCommand;
        public virtual ICommand TestCommand
        {
            get
            {

                if (_testCommand == null)
                {

                    _testCommand = new DelegateCommand(
                        () =>
                        {
                            MessageBox.Show("test");
                        },
                        // can execute
                        () => canGotoNext());
                }
                return _testCommand;
            }
        }

        public virtual bool canGotoNext()
        {
            if (string.IsNullOrEmpty(ComputerName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
