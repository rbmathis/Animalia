namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Monolene;

/// <summary>
/// Interface defining characteristics of Monolene (genus).
/// </summary>
public interface IMonolene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
