namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Acanthisitta;

/// <summary>
/// Interface defining characteristics of Acanthisitta (genus).
/// </summary>
public interface IAcanthisitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
