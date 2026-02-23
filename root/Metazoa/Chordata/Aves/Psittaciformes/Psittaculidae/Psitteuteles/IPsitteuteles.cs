namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Psitteuteles;

/// <summary>
/// Interface defining characteristics of Psitteuteles (genus).
/// </summary>
public interface IPsitteuteles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
