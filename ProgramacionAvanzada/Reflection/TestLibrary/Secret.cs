﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    //Sample secret class

    internal class Secret
    {
        private string SecretText;

        public Secret()
        {
            SecretText = "this is a secret... SHH!";
        }

        internal string GetSecret() => SecretText;
    }
}
