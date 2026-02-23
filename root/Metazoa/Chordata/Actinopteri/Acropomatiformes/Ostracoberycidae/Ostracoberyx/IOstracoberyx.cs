namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Ostracoberycidae.Ostracoberyx;

/// <summary>
/// Interface defining characteristics of Ostracoberyx (genus).
/// </summary>
public interface IOstracoberyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
