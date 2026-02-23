namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctodus;

/// <summary>
/// Interface defining characteristics of Arctodus (genus).
/// </summary>
public interface IArctodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
