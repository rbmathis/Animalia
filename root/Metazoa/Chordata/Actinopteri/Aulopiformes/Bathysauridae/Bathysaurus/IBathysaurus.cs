namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauridae.Bathysaurus;

/// <summary>
/// Interface defining characteristics of Bathysaurus (genus).
/// </summary>
public interface IBathysaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
