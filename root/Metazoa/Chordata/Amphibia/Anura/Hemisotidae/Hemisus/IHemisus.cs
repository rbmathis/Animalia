namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemisotidae.Hemisus;

/// <summary>
/// Interface defining characteristics of Hemisus (genus).
/// </summary>
public interface IHemisus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
