namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Indopacetus;

/// <summary>
/// Interface defining characteristics of Indopacetus (genus).
/// </summary>
public interface IIndopacetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
