namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Aplopelia;

/// <summary>
/// Interface defining characteristics of Aplopelia (genus).
/// </summary>
public interface IAplopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
