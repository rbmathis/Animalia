namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Vicugna;

/// <summary>
/// Interface defining characteristics of Vicugna (genus).
/// </summary>
public interface IVicugna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
