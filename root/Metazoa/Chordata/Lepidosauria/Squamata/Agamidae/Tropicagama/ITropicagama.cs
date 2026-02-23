namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tropicagama;

/// <summary>
/// Interface defining characteristics of Tropicagama (genus).
/// </summary>
public interface ITropicagama
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
