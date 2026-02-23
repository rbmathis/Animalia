namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Oenomys;

/// <summary>
/// Interface defining characteristics of Oenomys (genus).
/// </summary>
public interface IOenomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
