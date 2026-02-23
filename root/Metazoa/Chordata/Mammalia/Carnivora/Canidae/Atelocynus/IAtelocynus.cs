namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Atelocynus;

/// <summary>
/// Interface defining characteristics of Atelocynus (genus).
/// </summary>
public interface IAtelocynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
