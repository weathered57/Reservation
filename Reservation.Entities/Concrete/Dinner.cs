﻿using Reservation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Entities.Concrete
{
    public class Dinner : IEntity
    {
      
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        public string Fourth { get; set; }
    }
}
