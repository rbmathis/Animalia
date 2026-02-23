namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae.Erilepis;

/// <summary>
/// Interface defining characteristics of Erilepis (genus).
/// </summary>
public interface IErilepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
