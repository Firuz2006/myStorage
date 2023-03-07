﻿namespace Otchet.Core.Models;

public class Unit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
    public override string ToString()=> Name;

}