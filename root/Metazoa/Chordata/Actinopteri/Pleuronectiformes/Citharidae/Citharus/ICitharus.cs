namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Citharus;

/// <summary>
/// Interface defining characteristics of Citharus (genus).
/// </summary>
public interface ICitharus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
