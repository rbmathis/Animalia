namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Perameles;

/// <summary>
/// Interface defining characteristics of Perameles (genus).
/// </summary>
public interface IPerameles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
