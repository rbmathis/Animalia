namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae.Raphus;

/// <summary>
/// Interface defining characteristics of Raphus (genus).
/// </summary>
public interface IRaphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
