namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Phrynoglossus;

/// <summary>
/// Interface defining characteristics of Phrynoglossus (genus).
/// </summary>
public interface IPhrynoglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
