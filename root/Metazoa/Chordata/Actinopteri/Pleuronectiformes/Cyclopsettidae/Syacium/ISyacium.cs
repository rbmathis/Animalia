namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Syacium;

/// <summary>
/// Interface defining characteristics of Syacium (genus).
/// </summary>
public interface ISyacium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
