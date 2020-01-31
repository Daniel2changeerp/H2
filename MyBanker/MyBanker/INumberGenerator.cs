﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface INumberGenerator
    {
        int[] GeneratCardNumber(int length, int[] Prefix);
        int[] GenerateAccountNumber();

    }
}
