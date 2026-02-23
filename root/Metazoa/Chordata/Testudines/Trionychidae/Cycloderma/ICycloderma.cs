namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cycloderma;

/// <summary>
/// Interface defining characteristics of Cycloderma (genus).
/// </summary>
public interface ICycloderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
