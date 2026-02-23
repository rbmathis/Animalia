namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Pseudocarchariidae.Pseudocarcharias;

/// <summary>
/// Interface defining characteristics of Pseudocarcharias (genus).
/// </summary>
public interface IPseudocarcharias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
