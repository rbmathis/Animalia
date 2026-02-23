namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae.Kogia;

/// <summary>
/// Interface defining characteristics of Kogia (genus).
/// </summary>
public interface IKogia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
