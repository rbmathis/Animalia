namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Xeromys;

/// <summary>
/// Interface defining characteristics of Xeromys (genus).
/// </summary>
public interface IXeromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
