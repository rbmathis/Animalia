namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Waiomys;

/// <summary>
/// Interface defining characteristics of Waiomys (genus).
/// </summary>
public interface IWaiomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
