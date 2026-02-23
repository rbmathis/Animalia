namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Olisthops;

/// <summary>
/// Interface defining characteristics of Olisthops (genus).
/// </summary>
public interface IOlisthops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
