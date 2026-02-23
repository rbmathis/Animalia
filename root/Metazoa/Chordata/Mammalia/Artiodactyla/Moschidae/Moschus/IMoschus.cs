namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus;

/// <summary>
/// Interface defining characteristics of Moschus (genus).
/// </summary>
public interface IMoschus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
