namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenopsis;

/// <summary>
/// Interface defining characteristics of Scorpaenopsis (genus).
/// </summary>
public interface IScorpaenopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
