namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoclemys;

/// <summary>
/// Interface defining characteristics of Geoclemys (genus).
/// </summary>
public interface IGeoclemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
