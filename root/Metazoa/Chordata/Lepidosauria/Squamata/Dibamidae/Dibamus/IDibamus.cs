namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Dibamus;

/// <summary>
/// Interface defining characteristics of Dibamus (genus).
/// </summary>
public interface IDibamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
