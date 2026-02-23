namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys;

/// <summary>
/// Interface defining characteristics of Thallomys (genus).
/// </summary>
public interface IThallomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
