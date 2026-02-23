namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Opisthothylax;

/// <summary>
/// Interface defining characteristics of Opisthothylax (genus).
/// </summary>
public interface IOpisthothylax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
