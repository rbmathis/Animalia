namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Synchirus;

/// <summary>
/// Interface defining characteristics of Synchirus (genus).
/// </summary>
public interface ISynchirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
