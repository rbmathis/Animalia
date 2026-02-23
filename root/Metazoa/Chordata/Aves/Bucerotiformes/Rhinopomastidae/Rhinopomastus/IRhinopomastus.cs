namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Rhinopomastidae.Rhinopomastus;

/// <summary>
/// Interface defining characteristics of Rhinopomastus (genus).
/// </summary>
public interface IRhinopomastus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
