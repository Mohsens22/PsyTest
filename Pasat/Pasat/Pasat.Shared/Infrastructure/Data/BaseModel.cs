﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pasat.Models
{
    public abstract class BaseModel
    {
        public int? Id { get; set; }
        public override string ToString() => Id.ToString();
    }
}
