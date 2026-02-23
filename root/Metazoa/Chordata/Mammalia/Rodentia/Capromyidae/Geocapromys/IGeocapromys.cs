namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Capromyidae.Geocapromys;

/// <summary>
/// Interface defining characteristics of Geocapromys (genus).
/// </summary>
public interface IGeocapromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
