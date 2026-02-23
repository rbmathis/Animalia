namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Antilocapridae.Antilocapra;

/// <summary>
/// Interface defining characteristics of Antilocapra (genus).
/// </summary>
public interface IAntilocapra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
