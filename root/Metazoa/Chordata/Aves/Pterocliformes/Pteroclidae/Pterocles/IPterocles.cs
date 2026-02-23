namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae.Pterocles;

/// <summary>
/// Interface defining characteristics of Pterocles (genus).
/// </summary>
public interface IPterocles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
