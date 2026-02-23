namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Tetrabrachiidae.Tetrabrachium;

/// <summary>
/// Interface defining characteristics of Tetrabrachium (genus).
/// </summary>
public interface ITetrabrachium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
