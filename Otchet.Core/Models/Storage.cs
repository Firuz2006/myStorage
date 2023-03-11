﻿namespace Otchet.Core.Models;

public class Storage:EntityBase
{
    public string Name { get; set; }
    public string Address { get; set; }

    public List<Sale> Sales { get; set; }
    public List<Invoice> Invoices { get; set; }
    public override string ToString()=> Name;

}