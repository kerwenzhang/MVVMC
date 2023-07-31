using MVVMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Wizard
{
    internal class WizardController : Controller
    {
        public override void Initial()
        {
            FirstStep();
        }

        private void FirstStep()
        {
            ExecuteNavigation();
        }

    }
}
