namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Psectrogaster;

/// <summary>
/// Interface defining characteristics of Psectrogaster (genus).
/// </summary>
public interface IPsectrogaster
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
