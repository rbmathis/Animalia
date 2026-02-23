namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Hypogaleus;

/// <summary>
/// Interface defining characteristics of Hypogaleus (genus).
/// </summary>
public interface IHypogaleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
