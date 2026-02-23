namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bunomys;

/// <summary>
/// Interface defining characteristics of Bunomys (genus).
/// </summary>
public interface IBunomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
