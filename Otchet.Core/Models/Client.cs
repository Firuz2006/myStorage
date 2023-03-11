﻿namespace Otchet.Core.Models;

public class Client:EntityBase
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public List<Sale> Sales { get; set; }   
    public override string ToString()=> Name;

}