namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Mancopsetta;

/// <summary>
/// Interface defining characteristics of Mancopsetta (genus).
/// </summary>
public interface IMancopsetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
