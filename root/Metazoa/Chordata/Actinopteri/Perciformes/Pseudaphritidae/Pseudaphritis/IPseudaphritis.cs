namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pseudaphritidae.Pseudaphritis;

/// <summary>
/// Interface defining characteristics of Pseudaphritis (genus).
/// </summary>
public interface IPseudaphritis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
