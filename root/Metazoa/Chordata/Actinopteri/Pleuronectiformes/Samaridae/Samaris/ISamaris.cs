namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samaris;

/// <summary>
/// Interface defining characteristics of Samaris (genus).
/// </summary>
public interface ISamaris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
