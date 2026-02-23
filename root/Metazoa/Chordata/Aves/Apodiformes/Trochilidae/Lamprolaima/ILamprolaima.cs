namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lamprolaima;

/// <summary>
/// Interface defining characteristics of Lamprolaima (genus).
/// </summary>
public interface ILamprolaima
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
