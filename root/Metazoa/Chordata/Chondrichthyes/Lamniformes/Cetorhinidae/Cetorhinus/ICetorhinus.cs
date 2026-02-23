namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Cetorhinidae.Cetorhinus;

/// <summary>
/// Interface defining characteristics of Cetorhinus (genus).
/// </summary>
public interface ICetorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
