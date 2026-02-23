namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae.Trogonophis;

/// <summary>
/// Interface defining characteristics of Trogonophis (genus).
/// </summary>
public interface ITrogonophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
