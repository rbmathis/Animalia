namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Marleyella;

/// <summary>
/// Interface defining characteristics of Marleyella (genus).
/// </summary>
public interface IMarleyella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
