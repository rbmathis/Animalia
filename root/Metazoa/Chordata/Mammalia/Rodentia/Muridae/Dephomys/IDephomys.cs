namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dephomys;

/// <summary>
/// Interface defining characteristics of Dephomys (genus).
/// </summary>
public interface IDephomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
