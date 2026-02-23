namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Osornophryne;

/// <summary>
/// Interface defining characteristics of Osornophryne (genus).
/// </summary>
public interface IOsornophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
