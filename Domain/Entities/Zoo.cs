using System.Collections;
using System.Collections.Generic;

namespace Domain;

public class Zoo
{
    public int ZooId { get; set; }
    public ICollection Animals { get; set; } = new List<Animal>();
}