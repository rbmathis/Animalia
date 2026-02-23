namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Synoicum;

/// <summary>
/// Interface defining characteristics of Synoicum (genus).
/// </summary>
public interface ISynoicum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
