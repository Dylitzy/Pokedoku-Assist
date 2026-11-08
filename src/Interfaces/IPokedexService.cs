namespace PokedokuAssist.Interfaces;

public interface IPokedexService
{
    /// <summary>
    /// Given a valid pokemon, add it to the pokedex.
    /// </summary>
    /// <param name="entry">The entry to add.</param>
    void AddEntry(DexEntry entry);

    /// <summary>
    /// Given a valid pokemon, remove it from the pokedex (if present).
    /// </summary>
    /// <param name="entry"></param>
    void RemoveEntry(DexEntry entry);

    /// <summary>
    /// Given a valid pokemon, declare that you've found a shiny version.
    /// </summary>
    /// <param name="entry">The entry to toggle shiny.</param>
    void ToggleShiny(DexEntry entry);

    /// <summary>
    /// Populate the pokedex using the PokeAPI.
    /// </summary>
    void PopulatePokedex();
}