namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Nyctereutes;

/// <summary>
/// Interface defining characteristics of Nyctereutes (genus).
/// </summary>
public interface INyctereutes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
