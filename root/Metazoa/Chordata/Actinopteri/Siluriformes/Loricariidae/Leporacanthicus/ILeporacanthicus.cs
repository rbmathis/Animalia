namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leporacanthicus;

/// <summary>
/// Interface defining characteristics of Leporacanthicus (genus).
/// </summary>
public interface ILeporacanthicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
