namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Rhaphidura;

/// <summary>
/// Interface defining characteristics of Rhaphidura (genus).
/// </summary>
public interface IRhaphidura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
