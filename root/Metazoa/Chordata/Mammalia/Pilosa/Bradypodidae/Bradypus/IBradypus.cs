namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus;

/// <summary>
/// Interface defining characteristics of Bradypus (genus).
/// </summary>
public interface IBradypus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
