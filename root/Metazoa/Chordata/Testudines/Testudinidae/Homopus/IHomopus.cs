namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Homopus;

/// <summary>
/// Interface defining characteristics of Homopus (genus).
/// </summary>
public interface IHomopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
