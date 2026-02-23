namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Fritziana;

/// <summary>
/// Interface defining characteristics of Fritziana (genus).
/// </summary>
public interface IFritziana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
