namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ocyphaps;

/// <summary>
/// Interface defining characteristics of Ocyphaps (genus).
/// </summary>
public interface IOcyphaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
