namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Soestia;

/// <summary>
/// Interface defining characteristics of Soestia (genus).
/// </summary>
public interface ISoestia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
