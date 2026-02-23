namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dyscophus;

/// <summary>
/// Interface defining characteristics of Dyscophus (genus).
/// </summary>
public interface IDyscophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
