using System;
using System.Collections.Generic;

namespace PizzariaS09.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
