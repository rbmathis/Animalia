namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Tropidophis;

/// <summary>
/// Interface defining characteristics of Tropidophis (genus).
/// </summary>
public interface ITropidophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
