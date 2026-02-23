namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zyzomys;

/// <summary>
/// Interface defining characteristics of Zyzomys (genus).
/// </summary>
public interface IZyzomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
