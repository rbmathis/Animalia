namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Achiropsetta;

/// <summary>
/// Interface defining characteristics of Achiropsetta (genus).
/// </summary>
public interface IAchiropsetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
