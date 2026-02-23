namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Alopiidae.Alopias;

/// <summary>
/// Interface defining characteristics of Alopias (genus).
/// </summary>
public interface IAlopias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
