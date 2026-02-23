namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudelaphe;

/// <summary>
/// Interface defining characteristics of Pseudelaphe (genus).
/// </summary>
public interface IPseudelaphe
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
