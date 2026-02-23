namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Orcinus;

/// <summary>
/// Interface defining characteristics of Orcinus (genus).
/// </summary>
public interface IOrcinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
