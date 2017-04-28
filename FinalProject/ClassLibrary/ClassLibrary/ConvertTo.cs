using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ConvertTo
    {

        public static Status ConvertToStatus(int x)
        {
            switch (x)
            {
                case 0:
                    return Status.loginValidate;
                    
                case 1:
                    return Status.connectionSuccess;

                case 2:
                    return Status.loginTrue;

                case 3:
                    return Status.loginFalse;

                case 4:
                    return Status.onlineValidate;

                case 5:
                    return Status.onlineTrue;

                case 6:
                    return Status.onlineFalse;

                case 7:
                    return Status.messageSend;

                case 8:
                    return Status.messageReceive;

                case 9:
                    return Status.messageHistory;

                case 10:
                    return Status.messageHistorySend;

                case 11:
                    return Status.contactListRequest;

                case 12:
                    return Status.contactListSend;

                case 13:
                    return Status.requestChatRoom;

                case 14:
                    return Status.logout;

                default:
                    return Status.undefined;
                
            }
        }
    }
}
