using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace PierresMVC.Models
{
public string Vendor { get; set;}
    public string Description { get; set; }
    public string Name { get; set; }
      private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string description)
    {
      Description = description;
      _instances.Add(this);
    }