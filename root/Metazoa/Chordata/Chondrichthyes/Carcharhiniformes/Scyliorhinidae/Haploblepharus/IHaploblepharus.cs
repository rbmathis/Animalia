namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Haploblepharus;

/// <summary>
/// Interface defining characteristics of Haploblepharus (genus).
/// </summary>
public interface IHaploblepharus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
