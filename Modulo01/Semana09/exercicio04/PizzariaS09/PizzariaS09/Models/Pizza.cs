using System;
using System.Collections.Generic;

namespace PizzariaS09.Models;

public partial class Pizza
{
    public int Id { get; set; }

    public int IdMassas { get; set; }

    public int IdBordas { get; set; }

    public virtual Borda IdBordasNavigation { get; set; } = null!;

    public virtual Massa IdMassasNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();

    public virtual ICollection<PizzaSabore> PizzaSabores { get; } = new List<PizzaSabore>();
}
