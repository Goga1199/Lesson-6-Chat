﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDB.Models
{
    public class User
    {
        public int? ID { get; set; }
        public string? Nickname { get; set; }
        public virtual List<Message> SentMessages { get; set; } = [];
        public virtual List<Message> RecievedMessages { get; set; } = [];
    }
}
