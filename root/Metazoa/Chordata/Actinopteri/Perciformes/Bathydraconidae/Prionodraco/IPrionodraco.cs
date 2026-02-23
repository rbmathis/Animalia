namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Prionodraco;

/// <summary>
/// Interface defining characteristics of Prionodraco (genus).
/// </summary>
public interface IPrionodraco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
