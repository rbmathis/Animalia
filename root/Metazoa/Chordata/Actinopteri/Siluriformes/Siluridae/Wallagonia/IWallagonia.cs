namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Wallagonia;

/// <summary>
/// Interface defining characteristics of Wallagonia (genus).
/// </summary>
public interface IWallagonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
