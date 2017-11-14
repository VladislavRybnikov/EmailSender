﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSender.Abstractions;

namespace EmailSender
{
    public class ServerClient : IServerClient
    {
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
