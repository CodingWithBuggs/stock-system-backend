using System;
using System.Collections.Generic;

namespace StockSystem.Domian.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Count { get; set; }

    public bool Enabled { get; set; }

    public int IdType { get; set; }

    public int IdUnit { get; set; }

    public virtual ProductType IdTypeNavigation { get; set; } = null!;

    public virtual ProductUnit IdUnitNavigation { get; set; } = null!;
}
