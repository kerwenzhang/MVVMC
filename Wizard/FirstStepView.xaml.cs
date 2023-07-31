using System;
using System.Collections.Generic;
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

namespace Command.Wizard
{
    /// <summary>
    /// Interaction logic for FristStepView.xaml
    /// </summary>
    public partial class FirstStepView : UserControl
    {
        FirstStepViewModel viewModel;
        public FirstStepView()
        {
            InitializeComponent();
            viewModel = new FirstStepViewModel();   
            this.DataContext = viewModel;
        }

        private void ComputerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.HandleComputerNameTextChanged(((TextBox)sender).Text);
        }
    }
}
