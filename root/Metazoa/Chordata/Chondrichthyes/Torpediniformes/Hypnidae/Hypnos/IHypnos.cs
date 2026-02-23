namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Hypnidae.Hypnos;

/// <summary>
/// Interface defining characteristics of Hypnos (genus).
/// </summary>
public interface IHypnos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
