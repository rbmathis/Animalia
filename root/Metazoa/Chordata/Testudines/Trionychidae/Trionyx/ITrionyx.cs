namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Trionyx;

/// <summary>
/// Interface defining characteristics of Trionyx (genus).
/// </summary>
public interface ITrionyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
