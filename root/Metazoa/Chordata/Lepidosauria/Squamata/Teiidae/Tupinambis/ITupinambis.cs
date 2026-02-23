namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Tupinambis;

/// <summary>
/// Interface defining characteristics of Tupinambis (genus).
/// </summary>
public interface ITupinambis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
