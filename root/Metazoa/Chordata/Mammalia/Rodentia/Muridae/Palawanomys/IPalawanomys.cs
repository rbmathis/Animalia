namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Palawanomys;

/// <summary>
/// Interface defining characteristics of Palawanomys (genus).
/// </summary>
public interface IPalawanomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
