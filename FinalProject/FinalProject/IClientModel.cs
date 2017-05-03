using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    //IClientModel interface
    public interface IClientModel
    {
        
        string ID
        {
            get;
            set;
        }

        string Username
        {
            get;
            set;
        }

        bool LoginStatus
        {
            get;
            set;
        }

        Dictionary<string, bool> ContactList
        {
            get;
            set;
        }

        Dictionary<int, KeyValuePair<List<string>, List<string>>> ChatRooms
        {
            get;
            set;
        }

        bool AddContact
        {
            get;
            set;
        }

    }
}
