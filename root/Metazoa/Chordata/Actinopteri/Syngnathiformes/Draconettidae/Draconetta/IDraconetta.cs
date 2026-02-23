namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae.Draconetta;

/// <summary>
/// Interface defining characteristics of Draconetta (genus).
/// </summary>
public interface IDraconetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
