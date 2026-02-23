namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Apalone;

/// <summary>
/// Interface defining characteristics of Apalone (genus).
/// </summary>
public interface IApalone
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
