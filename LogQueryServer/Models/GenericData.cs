﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LogQueryServer.Models
{
    public class GenericData
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public dynamic Content { get; set; }
    }
}
