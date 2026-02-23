namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae.Zaglossus;

/// <summary>
/// Interface defining characteristics of Zaglossus (genus).
/// </summary>
public interface IZaglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
