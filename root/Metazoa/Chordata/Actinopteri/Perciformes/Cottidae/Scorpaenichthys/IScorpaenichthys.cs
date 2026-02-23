namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Scorpaenichthys;

/// <summary>
/// Interface defining characteristics of Scorpaenichthys (genus).
/// </summary>
public interface IScorpaenichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
