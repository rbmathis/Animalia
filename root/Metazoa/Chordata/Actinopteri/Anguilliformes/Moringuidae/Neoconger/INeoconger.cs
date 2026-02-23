namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Neoconger;

/// <summary>
/// Interface defining characteristics of Neoconger (genus).
/// </summary>
public interface INeoconger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
