namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyrio;

/// <summary>
/// Interface defining characteristics of Porphyrio (genus).
/// </summary>
public interface IPorphyrio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
