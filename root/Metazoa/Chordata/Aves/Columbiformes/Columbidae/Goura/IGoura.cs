namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Goura;

/// <summary>
/// Interface defining characteristics of Goura (genus).
/// </summary>
public interface IGoura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
