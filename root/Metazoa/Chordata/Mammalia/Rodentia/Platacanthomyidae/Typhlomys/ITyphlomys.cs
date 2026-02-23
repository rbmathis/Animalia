namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Typhlomys;

/// <summary>
/// Interface defining characteristics of Typhlomys (genus).
/// </summary>
public interface ITyphlomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
