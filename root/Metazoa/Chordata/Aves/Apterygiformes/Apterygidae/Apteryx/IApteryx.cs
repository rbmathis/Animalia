namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apterygiformes.Apterygidae.Apteryx;

/// <summary>
/// Interface defining characteristics of Apteryx (genus).
/// </summary>
public interface IApteryx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
