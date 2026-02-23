namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ramanella;

/// <summary>
/// Interface defining characteristics of Ramanella (genus).
/// </summary>
public interface IRamanella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
