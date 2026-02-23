namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Asterophrys;

/// <summary>
/// Interface defining characteristics of Asterophrys (genus).
/// </summary>
public interface IAsterophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
