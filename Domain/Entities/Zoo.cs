namespace Domain;

public class Zoo
{
    public int ZooId { get; set; }
    public ICollection<Animal> Animals { get; set; } = new List<Animal>();
}