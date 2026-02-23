namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Synaphobranchus;

/// <summary>
/// Interface defining characteristics of Synaphobranchus (genus).
/// </summary>
public interface ISynaphobranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
