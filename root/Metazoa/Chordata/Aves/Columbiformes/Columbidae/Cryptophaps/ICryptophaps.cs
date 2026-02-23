namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Cryptophaps;

/// <summary>
/// Interface defining characteristics of Cryptophaps (genus).
/// </summary>
public interface ICryptophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
