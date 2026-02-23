namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Deomys;

/// <summary>
/// Interface defining characteristics of Deomys (genus).
/// </summary>
public interface IDeomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
