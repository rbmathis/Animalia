namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Paraclaravis;

/// <summary>
/// Interface defining characteristics of Paraclaravis (genus).
/// </summary>
public interface IParaclaravis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
