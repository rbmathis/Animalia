namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Pseudobatos;

/// <summary>
/// Interface defining characteristics of Pseudobatos (genus).
/// </summary>
public interface IPseudobatos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
