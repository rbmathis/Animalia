namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ghatophryne;

/// <summary>
/// Interface defining characteristics of Ghatophryne (genus).
/// </summary>
public interface IGhatophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
