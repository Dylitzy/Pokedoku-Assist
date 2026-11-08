using PokedokuAssist.Enums;

/// <summary>
/// Represents a single pokemon in the pokedex.
/// </summary>
public class DexEntry
{
    public int Id { get; init; }
    public string Name { get; init; }
    public Region Region {get; init;}
    public List<Type> Type { get; init; }
    public List<Ability> Abilities { get; init; }
    public List<Move> Moves { get; init; }
    public bool Shiny { get; set; }
}