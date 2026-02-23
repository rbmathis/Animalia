namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Echymipera;

/// <summary>
/// Interface defining characteristics of Echymipera (genus).
/// </summary>
public interface IEchymipera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
