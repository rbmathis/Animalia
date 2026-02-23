namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Pseudoxenomystax;

/// <summary>
/// Interface defining characteristics of Pseudoxenomystax (genus).
/// </summary>
public interface IPseudoxenomystax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
