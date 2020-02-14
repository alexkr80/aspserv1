using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspserv1.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Sent by Email";
        }
    }
}
