namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Galidia;

/// <summary>
/// Interface defining characteristics of Galidia (genus).
/// </summary>
public interface IGalidia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
