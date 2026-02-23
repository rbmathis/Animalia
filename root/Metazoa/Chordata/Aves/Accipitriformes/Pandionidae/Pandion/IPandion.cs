namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Pandionidae.Pandion;

/// <summary>
/// Interface defining characteristics of Pandion (genus).
/// </summary>
public interface IPandion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
