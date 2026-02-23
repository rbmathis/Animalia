namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Starnoenas;

/// <summary>
/// Interface defining characteristics of Starnoenas (genus).
/// </summary>
public interface IStarnoenas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
