namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Psilodraco;

/// <summary>
/// Interface defining characteristics of Psilodraco (genus).
/// </summary>
public interface IPsilodraco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
