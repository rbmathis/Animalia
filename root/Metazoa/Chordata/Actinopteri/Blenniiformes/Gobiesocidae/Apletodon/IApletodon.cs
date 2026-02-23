namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Apletodon;

/// <summary>
/// Interface defining characteristics of Apletodon (genus).
/// </summary>
public interface IApletodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
