using System;
using System.Collections.Generic;

namespace PizzariaS09.Models;

public partial class Sabore
{
    public int Id { get; set; }

    public string? Sabor { get; set; }

    public virtual ICollection<PizzaSabore> PizzaSabores { get; } = new List<PizzaSabore>();
}
