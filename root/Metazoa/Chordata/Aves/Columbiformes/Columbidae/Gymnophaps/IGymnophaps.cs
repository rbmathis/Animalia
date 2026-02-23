namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Gymnophaps;

/// <summary>
/// Interface defining characteristics of Gymnophaps (genus).
/// </summary>
public interface IGymnophaps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
