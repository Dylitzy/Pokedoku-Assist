using PokedokuAssist.Interfaces;

namespace PokedokuAssist.Services;

public class PokedexService : IPokedexService
{
    ILogger<PokedexService> _logger;

    public PokedexService(ILogger<PokedexService> logger)
    {
        _logger = logger;
    }

    public void AddEntry(DexEntry entry)
    {
        
    }

    public void RemoveEntry(DexEntry entry)
    {
        
    }

    public void ToggleShiny(DexEntry entry)
    {
        entry.Shiny = !entry.Shiny;
    }

    public void PopulatePokedex()
    {
        
    }
}