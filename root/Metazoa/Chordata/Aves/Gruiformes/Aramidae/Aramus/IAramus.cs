namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aramidae.Aramus;

/// <summary>
/// Interface defining characteristics of Aramus (genus).
/// </summary>
public interface IAramus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
