namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Acestrorhynchus;

/// <summary>
/// Interface defining characteristics of Acestrorhynchus (genus).
/// </summary>
public interface IAcestrorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
