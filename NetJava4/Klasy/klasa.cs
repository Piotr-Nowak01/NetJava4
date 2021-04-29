using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Kurs
{
    public int ID {set; get; }
    public string waluta { set; get; }
    public double kurs { set; get; }
    public DateTime data { set; get; }
}
public class waluty
{
    public string disclaimer { set; get; }
    public string license { set; get; }
    public int timestamp { set; get; }
    public string Base { set; get; }
    public Dictionary<string, double> Rates { set; get; }
}