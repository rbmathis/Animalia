namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae.Lepidosiren;

/// <summary>
/// Interface defining characteristics of Lepidosiren (genus).
/// </summary>
public interface ILepidosiren
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
