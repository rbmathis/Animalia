namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Synclidopus;

/// <summary>
/// Interface defining characteristics of Synclidopus (genus).
/// </summary>
public interface ISynclidopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
