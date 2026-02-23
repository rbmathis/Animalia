namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Psychrophrynella;

/// <summary>
/// Interface defining characteristics of Psychrophrynella (genus).
/// </summary>
public interface IPsychrophrynella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
