namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Dendrophryniscus;

/// <summary>
/// Interface defining characteristics of Dendrophryniscus (genus).
/// </summary>
public interface IDendrophryniscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
