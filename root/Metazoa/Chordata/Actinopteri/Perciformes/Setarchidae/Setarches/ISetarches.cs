namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Setarches;

/// <summary>
/// Interface defining characteristics of Setarches (genus).
/// </summary>
public interface ISetarches
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
