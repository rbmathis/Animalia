namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Hyalinobatrachium;

/// <summary>
/// Interface defining characteristics of Hyalinobatrachium (genus).
/// </summary>
public interface IHyalinobatrachium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
