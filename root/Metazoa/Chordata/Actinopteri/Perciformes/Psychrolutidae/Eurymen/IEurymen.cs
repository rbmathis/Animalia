namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Eurymen;

/// <summary>
/// Interface defining characteristics of Eurymen (genus).
/// </summary>
public interface IEurymen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
