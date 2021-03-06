﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionLand.Models
{
    
    public class User
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public long PIN { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

         public string Password { get; set; }

    }
}
