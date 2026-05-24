using System.Text.Json.Serialization;

namespace BlazorDragonBallApi.Models
{
public class Personagem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OriginPlanet OriginPlanet { get; set; }
    public List<Transformation> Transformations { get; set; }
}

public class OriginPlanet
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Transformation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
}
}