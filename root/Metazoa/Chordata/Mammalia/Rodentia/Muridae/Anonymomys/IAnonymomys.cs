namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Anonymomys;

/// <summary>
/// Interface defining characteristics of Anonymomys (genus).
/// </summary>
public interface IAnonymomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
