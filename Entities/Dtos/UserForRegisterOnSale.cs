﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserForRegisterOnSale: IDto
    {
        public string Email { get; set; }
        public string CuponCode { get; set; }
    }
}
