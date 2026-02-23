namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Saurothera;

/// <summary>
/// Interface defining characteristics of Saurothera (genus).
/// </summary>
public interface ISaurothera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
