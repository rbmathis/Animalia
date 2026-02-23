namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Rhynchactis;

/// <summary>
/// Interface defining characteristics of Rhynchactis (genus).
/// </summary>
public interface IRhynchactis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
