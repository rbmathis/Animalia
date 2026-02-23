namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Abeomelomys;

/// <summary>
/// Interface defining characteristics of Abeomelomys (genus).
/// </summary>
public interface IAbeomelomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
