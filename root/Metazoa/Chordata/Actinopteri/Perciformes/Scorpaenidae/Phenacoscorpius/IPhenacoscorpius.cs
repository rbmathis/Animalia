namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Phenacoscorpius;

/// <summary>
/// Interface defining characteristics of Phenacoscorpius (genus).
/// </summary>
public interface IPhenacoscorpius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
