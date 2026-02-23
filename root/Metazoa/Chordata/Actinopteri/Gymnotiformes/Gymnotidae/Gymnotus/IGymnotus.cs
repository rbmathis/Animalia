namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Gymnotus;

/// <summary>
/// Interface defining characteristics of Gymnotus (genus).
/// </summary>
public interface IGymnotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
