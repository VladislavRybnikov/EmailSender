﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Abstractions
{
    public interface IClient
    {
        string Name { get; set; }
        string Email { get; set; }
    }
}
