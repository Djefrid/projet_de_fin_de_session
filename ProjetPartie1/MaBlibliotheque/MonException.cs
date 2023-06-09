﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBlibliotheque
{
    public class MonException : Exception
    {
        public MonException(string message) : base(message)
        {
        }

        public MonException(string message, Exception autreexception) : base(message, autreexception)
        {
        }

        public int ErrorCode { get; set; }
    }
}
