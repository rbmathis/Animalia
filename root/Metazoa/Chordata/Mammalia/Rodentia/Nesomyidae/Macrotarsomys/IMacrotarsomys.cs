namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Macrotarsomys;

/// <summary>
/// Interface defining characteristics of Macrotarsomys (genus).
/// </summary>
public interface IMacrotarsomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
