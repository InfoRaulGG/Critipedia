﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CritipediaApi.Auth
{
    public class JsonWebToken
    {

        public string Access_Token { get; set; }
        public string Token_Type { get; set; }
        public int Expires_in { get; set; }
        public string Refresh_Token { get; set; }
    }
}
