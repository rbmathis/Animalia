namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Hypsipetes;

/// <summary>
/// Interface defining characteristics of Hypsipetes (genus).
/// </summary>
public interface IHypsipetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
