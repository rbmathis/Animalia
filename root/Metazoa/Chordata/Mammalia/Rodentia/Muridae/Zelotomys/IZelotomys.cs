namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zelotomys;

/// <summary>
/// Interface defining characteristics of Zelotomys (genus).
/// </summary>
public interface IZelotomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
