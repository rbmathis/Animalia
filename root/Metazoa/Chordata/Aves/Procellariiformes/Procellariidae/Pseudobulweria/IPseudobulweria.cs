namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pseudobulweria;

/// <summary>
/// Interface defining characteristics of Pseudobulweria (genus).
/// </summary>
public interface IPseudobulweria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
