namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Brasilotyphlus;

/// <summary>
/// Interface defining characteristics of Brasilotyphlus (genus).
/// </summary>
public interface IBrasilotyphlus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
