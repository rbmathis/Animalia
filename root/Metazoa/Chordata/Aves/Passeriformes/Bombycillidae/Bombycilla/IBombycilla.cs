namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Bombycilla;

/// <summary>
/// Interface defining characteristics of Bombycilla (genus).
/// </summary>
public interface IBombycilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
