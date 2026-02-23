namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ansonia;

/// <summary>
/// Interface defining characteristics of Ansonia (genus).
/// </summary>
public interface IAnsonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
