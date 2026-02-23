namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Anaxyrus;

/// <summary>
/// Interface defining characteristics of Anaxyrus (genus).
/// </summary>
public interface IAnaxyrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
