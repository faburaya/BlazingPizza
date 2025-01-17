﻿using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza.Model
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pizza
    {
        public static int DefaultSize => 12;
        public static int MinimumSize => 9;
        public static int MaximumSize => 17;

        public int Id { get; set; }

        public int OrderId { get; set; }

        public PizzaSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        public List<PizzaTopping> Toppings { get; set; }

        public decimal GetBasePrice()
        {
            return Size / (decimal)DefaultSize * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice();
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
