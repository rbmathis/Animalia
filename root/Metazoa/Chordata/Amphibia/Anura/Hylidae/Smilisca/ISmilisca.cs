namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Smilisca;

/// <summary>
/// Interface defining characteristics of Smilisca (genus).
/// </summary>
public interface ISmilisca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
