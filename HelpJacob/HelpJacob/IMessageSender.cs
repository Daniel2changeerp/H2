﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
     interface IMessageSender
    {
        string SendMessage(Message m);

        string SendToAll(Message m);
    }
}
