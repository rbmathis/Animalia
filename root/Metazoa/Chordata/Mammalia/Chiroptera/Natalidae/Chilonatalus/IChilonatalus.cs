namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Chilonatalus;

/// <summary>
/// Interface defining characteristics of Chilonatalus (genus).
/// </summary>
public interface IChilonatalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
