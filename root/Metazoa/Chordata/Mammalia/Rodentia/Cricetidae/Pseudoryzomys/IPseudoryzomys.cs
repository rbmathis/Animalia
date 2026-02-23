namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Pseudoryzomys;

/// <summary>
/// Interface defining characteristics of Pseudoryzomys (genus).
/// </summary>
public interface IPseudoryzomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
