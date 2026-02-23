namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Speothos;

/// <summary>
/// Interface defining characteristics of Speothos (genus).
/// </summary>
public interface ISpeothos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
