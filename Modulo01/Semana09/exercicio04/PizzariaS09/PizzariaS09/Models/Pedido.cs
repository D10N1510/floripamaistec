using System;
using System.Collections.Generic;

namespace PizzariaS09.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int IdStatus { get; set; }

    public int IdPizza { get; set; }

    public virtual Pizza IdPizzaNavigation { get; set; } = null!;

    public virtual Estado IdStatusNavigation { get; set; } = null!;
}
