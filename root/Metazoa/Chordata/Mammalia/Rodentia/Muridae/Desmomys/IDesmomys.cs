namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Desmomys;

/// <summary>
/// Interface defining characteristics of Desmomys (genus).
/// </summary>
public interface IDesmomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
