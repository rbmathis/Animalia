namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Isoodon;

/// <summary>
/// Interface defining characteristics of Isoodon (genus).
/// </summary>
public interface IIsoodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
