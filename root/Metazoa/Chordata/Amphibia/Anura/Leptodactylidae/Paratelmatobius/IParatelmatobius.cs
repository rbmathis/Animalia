namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Paratelmatobius;

/// <summary>
/// Interface defining characteristics of Paratelmatobius (genus).
/// </summary>
public interface IParatelmatobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
