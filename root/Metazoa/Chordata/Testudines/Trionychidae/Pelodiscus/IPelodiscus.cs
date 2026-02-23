namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Interface defining characteristics of Pelodiscus (genus).
/// </summary>
public interface IPelodiscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
