namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthodidae.Paralichthodes;

/// <summary>
/// Interface defining characteristics of Paralichthodes (genus).
/// </summary>
public interface IParalichthodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
