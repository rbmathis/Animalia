namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Anelytropsis;

/// <summary>
/// Interface defining characteristics of Anelytropsis (genus).
/// </summary>
public interface IAnelytropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
