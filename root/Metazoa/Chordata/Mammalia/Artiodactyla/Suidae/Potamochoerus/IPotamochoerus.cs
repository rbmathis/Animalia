namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Potamochoerus;

/// <summary>
/// Interface defining characteristics of Potamochoerus (genus).
/// </summary>
public interface IPotamochoerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
