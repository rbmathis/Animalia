namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Platacanthomys;

/// <summary>
/// Interface defining characteristics of Platacanthomys (genus).
/// </summary>
public interface IPlatacanthomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
