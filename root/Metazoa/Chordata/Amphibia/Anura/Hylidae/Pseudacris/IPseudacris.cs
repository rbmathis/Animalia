namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudacris;

/// <summary>
/// Interface defining characteristics of Pseudacris (genus).
/// </summary>
public interface IPseudacris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
