namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Ninurta;

/// <summary>
/// Interface defining characteristics of Ninurta (genus).
/// </summary>
public interface INinurta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
