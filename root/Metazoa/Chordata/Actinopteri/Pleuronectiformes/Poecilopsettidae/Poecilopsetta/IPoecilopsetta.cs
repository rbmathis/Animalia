namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Poecilopsetta;

/// <summary>
/// Interface defining characteristics of Poecilopsetta (genus).
/// </summary>
public interface IPoecilopsetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
