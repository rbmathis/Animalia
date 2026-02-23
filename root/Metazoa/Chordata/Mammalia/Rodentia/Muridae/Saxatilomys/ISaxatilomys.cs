namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Saxatilomys;

/// <summary>
/// Interface defining characteristics of Saxatilomys (genus).
/// </summary>
public interface ISaxatilomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
