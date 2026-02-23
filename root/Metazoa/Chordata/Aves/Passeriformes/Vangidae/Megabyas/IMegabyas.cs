namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Megabyas;

/// <summary>
/// Interface defining characteristics of Megabyas (genus).
/// </summary>
public interface IMegabyas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
