namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Colistium;

/// <summary>
/// Interface defining characteristics of Colistium (genus).
/// </summary>
public interface IColistium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
