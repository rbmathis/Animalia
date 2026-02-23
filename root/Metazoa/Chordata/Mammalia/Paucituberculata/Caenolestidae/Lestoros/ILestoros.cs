namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Lestoros;

/// <summary>
/// Interface defining characteristics of Lestoros (genus).
/// </summary>
public interface ILestoros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
