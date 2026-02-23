namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Zanclorhynchidae.Zanclorhynchus;

/// <summary>
/// Interface defining characteristics of Zanclorhynchus (genus).
/// </summary>
public interface IZanclorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
