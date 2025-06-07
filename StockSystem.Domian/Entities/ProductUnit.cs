using System;
using System.Collections.Generic;

namespace StockSystem.Domian.Entities;

public partial class ProductUnit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
