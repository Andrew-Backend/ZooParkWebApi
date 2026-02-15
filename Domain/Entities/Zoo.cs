namespace Domain;

public class Zoo
{
    public int Id { get; set; }
    public ICollection<Animal> Animals { get; set; } = new List<Animal>();
}