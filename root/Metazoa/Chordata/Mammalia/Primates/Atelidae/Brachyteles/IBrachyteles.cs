namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Brachyteles;

/// <summary>
/// Interface defining characteristics of Brachyteles (genus).
/// </summary>
public interface IBrachyteles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
