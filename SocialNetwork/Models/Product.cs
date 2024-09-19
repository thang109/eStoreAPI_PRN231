using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Weight { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
