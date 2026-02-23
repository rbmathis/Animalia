namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Hylodes;

/// <summary>
/// Interface defining characteristics of Hylodes (genus).
/// </summary>
public interface IHylodes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
