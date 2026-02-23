namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Microgoura;

/// <summary>
/// Interface defining characteristics of Microgoura (genus).
/// </summary>
public interface IMicrogoura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
