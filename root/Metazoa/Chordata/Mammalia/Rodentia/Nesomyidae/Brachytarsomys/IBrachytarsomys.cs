namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Brachytarsomys;

/// <summary>
/// Interface defining characteristics of Brachytarsomys (genus).
/// </summary>
public interface IBrachytarsomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
