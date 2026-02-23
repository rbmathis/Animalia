namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Pyramodon;

/// <summary>
/// Interface defining characteristics of Pyramodon (genus).
/// </summary>
public interface IPyramodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
