namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae.Psilorhynchus;

/// <summary>
/// Interface defining characteristics of Psilorhynchus (genus).
/// </summary>
public interface IPsilorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
