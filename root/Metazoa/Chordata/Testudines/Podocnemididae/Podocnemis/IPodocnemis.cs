namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Interface defining characteristics of Podocnemis (genus).
/// </summary>
public interface IPodocnemis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
