namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae.Anoplopoma;

/// <summary>
/// Interface defining characteristics of Anoplopoma (genus).
/// </summary>
public interface IAnoplopoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
