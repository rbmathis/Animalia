namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Komodomys;

/// <summary>
/// Interface defining characteristics of Komodomys (genus).
/// </summary>
public interface IKomodomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
