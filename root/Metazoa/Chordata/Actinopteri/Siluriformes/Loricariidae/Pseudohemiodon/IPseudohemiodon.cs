namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudohemiodon;

/// <summary>
/// Interface defining characteristics of Pseudohemiodon (genus).
/// </summary>
public interface IPseudohemiodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
