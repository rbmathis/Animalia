namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Hylochoerus;

/// <summary>
/// Interface defining characteristics of Hylochoerus (genus).
/// </summary>
public interface IHylochoerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
