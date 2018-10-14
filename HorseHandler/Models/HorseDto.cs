using System;
using System.Collections.Generic;
using System.Text;

namespace HorseHandler.Models
{
    public class HorseDto
    {
        public string Id;
        public string Name;
        public double Price;

        public HorseDto()
        {
        }

        public HorseDto(string Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }
}
