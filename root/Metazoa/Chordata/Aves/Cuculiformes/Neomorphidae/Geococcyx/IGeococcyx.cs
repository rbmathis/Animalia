namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Geococcyx;

/// <summary>
/// Interface defining characteristics of Geococcyx (genus).
/// </summary>
public interface IGeococcyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
