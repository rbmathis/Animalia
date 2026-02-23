namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Zenaida;

/// <summary>
/// Interface defining characteristics of Zenaida (genus).
/// </summary>
public interface IZenaida
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
