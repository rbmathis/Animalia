namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Psettodidae.Psettodes;

/// <summary>
/// Interface defining characteristics of Psettodes (genus).
/// </summary>
public interface IPsettodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
