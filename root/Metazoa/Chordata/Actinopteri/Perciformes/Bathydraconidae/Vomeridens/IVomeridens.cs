namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Vomeridens;

/// <summary>
/// Interface defining characteristics of Vomeridens (genus).
/// </summary>
public interface IVomeridens
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
