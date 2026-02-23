namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Claravis;

/// <summary>
/// Interface defining characteristics of Claravis (genus).
/// </summary>
public interface IClaravis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
