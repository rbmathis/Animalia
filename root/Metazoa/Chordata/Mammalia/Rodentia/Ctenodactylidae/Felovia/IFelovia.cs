namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenodactylidae.Felovia;

/// <summary>
/// Interface defining characteristics of Felovia (genus).
/// </summary>
public interface IFelovia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
