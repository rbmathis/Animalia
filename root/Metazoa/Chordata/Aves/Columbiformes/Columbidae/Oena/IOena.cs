namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Oena;

/// <summary>
/// Interface defining characteristics of Oena (genus).
/// </summary>
public interface IOena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
