namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Brotomys;

/// <summary>
/// Interface defining characteristics of Brotomys (genus).
/// </summary>
public interface IBrotomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
