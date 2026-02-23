namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Eupsophus;

/// <summary>
/// Interface defining characteristics of Eupsophus (genus).
/// </summary>
public interface IEupsophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
