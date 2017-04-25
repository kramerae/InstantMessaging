using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Status_Enum
    {
        public enum Status { loginValidate, loginTrue, loginFalse, onlineValidate, onlineTrue, onlineFalse, messageSend, messageReceive, messageHistory, messageHistorySend, logout};
    }
}
