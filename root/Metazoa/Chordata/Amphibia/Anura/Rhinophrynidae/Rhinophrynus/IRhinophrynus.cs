namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinophrynidae.Rhinophrynus;

/// <summary>
/// Interface defining characteristics of Rhinophrynus (genus).
/// </summary>
public interface IRhinophrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
