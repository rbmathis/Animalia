namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Hypoplectrodes;

/// <summary>
/// Interface defining characteristics of Hypoplectrodes (genus).
/// </summary>
public interface IHypoplectrodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
