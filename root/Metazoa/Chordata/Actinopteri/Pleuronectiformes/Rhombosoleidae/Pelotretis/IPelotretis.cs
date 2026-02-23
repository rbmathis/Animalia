namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Pelotretis;

/// <summary>
/// Interface defining characteristics of Pelotretis (genus).
/// </summary>
public interface IPelotretis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
