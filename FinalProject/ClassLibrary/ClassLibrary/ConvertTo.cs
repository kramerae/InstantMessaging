using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ConvertTos
    {

        /// <summary>
        /// UNUSED
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

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

        public static int ConvertToInt(Status s)
        {
            switch (s)
            {
                case Status.loginValidate:
                    return 0;

                case Status.connectionSuccess:
                    return 1;

                case Status.loginTrue:
                    return 2;

                case Status.loginFalse:
                    return 3;

                case Status.onlineValidate:
                    return 4;

                case Status.onlineTrue:
                    return 5;

                case Status.onlineFalse:
                    return 6;

                case Status.messageSend:
                    return 7;

                case Status.messageReceive:
                    return 8;

                case Status.messageHistory:
                    return 9;

                case Status.messageHistorySend:
                    return 10;

                case Status.contactListRequest:
                    return 11;

                case Status.contactListSend:
                    return 12;

                case Status.requestChatRoom:
                    return 13;

                case Status.logout:
                    return 14;

                default:
                    return 15;

            }

        }
    }
}
