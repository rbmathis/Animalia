namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ranoidea;

/// <summary>
/// Interface defining characteristics of Ranoidea (genus).
/// </summary>
public interface IRanoidea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
