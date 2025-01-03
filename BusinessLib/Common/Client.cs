﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common;
public class Client
{
    public string  ClientCode   { get; set; }
    public string  CompanyName  { get; set; }
    public string  Address1     { get; set; }
    public string  Address2     { get; set; }
    public string  City         { get; set; }
    public string  Province     { get; set; }
    public string  PostalCode   { get; set; }
    public decimal YTDSales     { get; set; }
    public bool    IsCreditHold { get; set; }
    public string  Notes        { get; set; }
}
