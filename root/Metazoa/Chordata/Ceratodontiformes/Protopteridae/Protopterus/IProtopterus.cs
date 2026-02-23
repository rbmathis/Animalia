namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

/// <summary>
/// Interface defining characteristics of Protopterus (genus).
/// </summary>
public interface IProtopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
