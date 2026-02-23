namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hypsiboas;

/// <summary>
/// Interface defining characteristics of Hypsiboas (genus).
/// </summary>
public interface IHypsiboas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
