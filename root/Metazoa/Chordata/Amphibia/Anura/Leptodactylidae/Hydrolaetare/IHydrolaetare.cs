namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Hydrolaetare;

/// <summary>
/// Interface defining characteristics of Hydrolaetare (genus).
/// </summary>
public interface IHydrolaetare
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
