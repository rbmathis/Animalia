namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Rhaphiodon;

/// <summary>
/// Interface defining characteristics of Rhaphiodon (genus).
/// </summary>
public interface IRhaphiodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
