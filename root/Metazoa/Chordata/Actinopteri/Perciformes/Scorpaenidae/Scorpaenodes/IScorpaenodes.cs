namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenodes;

/// <summary>
/// Interface defining characteristics of Scorpaenodes (genus).
/// </summary>
public interface IScorpaenodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
