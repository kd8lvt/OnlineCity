﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transfer
{
    [Serializable]
    public class ModelUpdateChat
    {
        public DateTime Time;

        public List<Chat> Chats;
    }
}
