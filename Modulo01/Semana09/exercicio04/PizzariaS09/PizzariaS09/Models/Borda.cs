using System;
using System.Collections.Generic;

namespace PizzariaS09.Models;

public partial class Borda
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pizza> Pizzas { get; } = new List<Pizza>();
}
