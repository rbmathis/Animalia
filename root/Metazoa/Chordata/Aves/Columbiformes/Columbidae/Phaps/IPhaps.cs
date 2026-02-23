namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Phaps;

/// <summary>
/// Interface defining characteristics of Phaps (genus).
/// </summary>
public interface IPhaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
