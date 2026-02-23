namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Amyda;

/// <summary>
/// Interface defining characteristics of Amyda (genus).
/// </summary>
public interface IAmyda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
