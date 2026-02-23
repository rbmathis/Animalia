namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Chaeropus;

/// <summary>
/// Interface defining characteristics of Chaeropus (genus).
/// </summary>
public interface IChaeropus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
