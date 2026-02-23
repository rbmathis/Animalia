namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Sacura;

/// <summary>
/// Interface defining characteristics of Sacura (genus).
/// </summary>
public interface ISacura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
