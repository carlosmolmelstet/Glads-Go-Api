﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Models
{
    public class FilterData
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }

    }
}
