namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tympanocryptis;

/// <summary>
/// Interface defining characteristics of Tympanocryptis (genus).
/// </summary>
public interface ITympanocryptis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
