namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae.Cottoperca;

/// <summary>
/// Interface defining characteristics of Cottoperca (genus).
/// </summary>
public interface ICottoperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
