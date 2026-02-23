namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Anisomys;

/// <summary>
/// Interface defining characteristics of Anisomys (genus).
/// </summary>
public interface IAnisomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
