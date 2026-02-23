namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Geochelone;

/// <summary>
/// Interface defining characteristics of Geochelone (genus).
/// </summary>
public interface IGeochelone
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
