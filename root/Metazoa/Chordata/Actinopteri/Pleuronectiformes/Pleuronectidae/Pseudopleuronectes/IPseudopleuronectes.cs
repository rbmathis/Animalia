namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pseudopleuronectes;

/// <summary>
/// Interface defining characteristics of Pseudopleuronectes (genus).
/// </summary>
public interface IPseudopleuronectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
