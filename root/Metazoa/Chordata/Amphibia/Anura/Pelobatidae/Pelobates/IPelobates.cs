namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Pelobates;

/// <summary>
/// Interface defining characteristics of Pelobates (genus).
/// </summary>
public interface IPelobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
