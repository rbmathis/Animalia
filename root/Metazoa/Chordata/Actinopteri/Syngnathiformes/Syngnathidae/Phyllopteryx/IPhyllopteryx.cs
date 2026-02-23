namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Phyllopteryx;

/// <summary>
/// Interface defining characteristics of Phyllopteryx (genus).
/// </summary>
public interface IPhyllopteryx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
