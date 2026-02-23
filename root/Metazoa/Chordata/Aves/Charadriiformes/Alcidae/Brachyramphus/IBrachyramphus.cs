namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Brachyramphus;

/// <summary>
/// Interface defining characteristics of Brachyramphus (genus).
/// </summary>
public interface IBrachyramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
