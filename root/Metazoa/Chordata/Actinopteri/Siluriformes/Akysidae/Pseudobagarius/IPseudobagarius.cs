namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Pseudobagarius;

/// <summary>
/// Interface defining characteristics of Pseudobagarius (genus).
/// </summary>
public interface IPseudobagarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
