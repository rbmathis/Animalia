namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Caribicus;

/// <summary>
/// Interface defining characteristics of Caribicus (genus).
/// </summary>
public interface ICaribicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
