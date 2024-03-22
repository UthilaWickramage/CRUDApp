﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayProject.Model
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Username { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }


        public string Password { get; set; }
    }
}
