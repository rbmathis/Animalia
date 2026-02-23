namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Pantodontidae.Pantodon;

/// <summary>
/// Interface defining characteristics of Pantodon (genus).
/// </summary>
public interface IPantodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
