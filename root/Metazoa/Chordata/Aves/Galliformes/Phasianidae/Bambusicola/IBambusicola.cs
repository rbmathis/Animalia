namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Bambusicola;

/// <summary>
/// Interface defining characteristics of Bambusicola (genus).
/// </summary>
public interface IBambusicola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
