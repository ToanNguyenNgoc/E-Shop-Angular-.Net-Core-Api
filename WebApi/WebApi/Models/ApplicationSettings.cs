﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string client_URL { get; set; }
    }
}
