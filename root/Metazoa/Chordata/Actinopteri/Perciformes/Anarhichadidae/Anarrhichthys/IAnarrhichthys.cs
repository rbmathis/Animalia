namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anarhichadidae.Anarrhichthys;

/// <summary>
/// Interface defining characteristics of Anarrhichthys (genus).
/// </summary>
public interface IAnarrhichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
