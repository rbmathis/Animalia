namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Strongylopus;

/// <summary>
/// Interface defining characteristics of Strongylopus (genus).
/// </summary>
public interface IStrongylopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
