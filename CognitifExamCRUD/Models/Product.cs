using System;
using System.Collections.Generic;

namespace CognitifExamCRUD.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }
}
