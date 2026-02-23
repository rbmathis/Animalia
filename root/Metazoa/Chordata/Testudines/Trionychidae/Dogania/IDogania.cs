namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Dogania;

/// <summary>
/// Interface defining characteristics of Dogania (genus).
/// </summary>
public interface IDogania
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
