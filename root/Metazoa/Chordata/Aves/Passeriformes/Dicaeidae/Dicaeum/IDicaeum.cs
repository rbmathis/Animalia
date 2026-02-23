namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae.Dicaeum;

/// <summary>
/// Interface defining characteristics of Dicaeum (genus).
/// </summary>
public interface IDicaeum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
