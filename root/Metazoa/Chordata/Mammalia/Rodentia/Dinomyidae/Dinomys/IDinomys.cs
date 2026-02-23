namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dinomyidae.Dinomys;

/// <summary>
/// Interface defining characteristics of Dinomys (genus).
/// </summary>
public interface IDinomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
