namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Dendrochirus;

/// <summary>
/// Interface defining characteristics of Dendrochirus (genus).
/// </summary>
public interface IDendrochirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
