namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

/// <summary>
/// Interface defining characteristics of Parotomys (genus).
/// </summary>
public interface IParotomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
