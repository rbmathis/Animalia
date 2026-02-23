namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Lichanura;

/// <summary>
/// Interface defining characteristics of Lichanura (genus).
/// </summary>
public interface ILichanura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
