namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Melursus;

/// <summary>
/// Interface defining characteristics of Melursus (genus).
/// </summary>
public interface IMelursus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
