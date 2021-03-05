﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Remployee
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        [ForeignKey("Username")]
        public LoginDetails LoginDetails  { get; set; }

    }
}