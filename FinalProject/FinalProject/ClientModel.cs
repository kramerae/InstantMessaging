using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ClientModel : IClientModel
    {
        private bool _loginStatus;
        private List<string> messages;
        

        public ClientModel()
        {
            
        }

        public bool LoginStatus
        {
            get
            {
                return _loginStatus;
            }
            set
            {
                _loginStatus = value;
            }
        }
  




    }
}
