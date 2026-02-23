namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Dicamptodontidae.Dicamptodon;

/// <summary>
/// Interface defining characteristics of Dicamptodon (genus).
/// </summary>
public interface IDicamptodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
