namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crossomys;

/// <summary>
/// Interface defining characteristics of Crossomys (genus).
/// </summary>
public interface ICrossomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
