﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas.Entities
{
    public class BallFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}
