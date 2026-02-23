namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Liocranium;

/// <summary>
/// Interface defining characteristics of Liocranium (genus).
/// </summary>
public interface ILiocranium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
