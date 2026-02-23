namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Rafetus;

/// <summary>
/// Interface defining characteristics of Rafetus (genus).
/// </summary>
public interface IRafetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
