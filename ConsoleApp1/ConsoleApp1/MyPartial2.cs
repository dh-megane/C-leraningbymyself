﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class MyPartial
    {
        public string Greet()
        {
            return $"こんにちは、{this.LastName}{this.FirstName}さん！";
        }
    }
}
