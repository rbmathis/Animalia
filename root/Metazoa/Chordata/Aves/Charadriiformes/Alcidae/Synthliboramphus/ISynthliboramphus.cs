namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Synthliboramphus;

/// <summary>
/// Interface defining characteristics of Synthliboramphus (genus).
/// </summary>
public interface ISynthliboramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
