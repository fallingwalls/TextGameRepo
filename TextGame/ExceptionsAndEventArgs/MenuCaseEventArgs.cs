using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.ExceptionsAndEventArgs
{
    class MenuCaseEventArgs : EventArgs
    {
        private string _menuCase;
        public MenuCaseEventArgs(string menucase)
        {
            _menuCase = menucase;
        }
    }
}
