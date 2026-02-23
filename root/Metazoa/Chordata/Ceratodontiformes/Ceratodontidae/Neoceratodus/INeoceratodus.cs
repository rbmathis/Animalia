namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Ceratodontidae.Neoceratodus;

/// <summary>
/// Interface defining characteristics of Neoceratodus (genus).
/// </summary>
public interface INeoceratodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
