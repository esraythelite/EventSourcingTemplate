using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class SimpleRegisterEventHandler
    {
        public event EventHandler NewUserRegistered;

        public void OnNewUserRegistered(EventArgs eventArgs )
        {
            NewUserRegistered?.Invoke( this, eventArgs );
        }
    }
}
