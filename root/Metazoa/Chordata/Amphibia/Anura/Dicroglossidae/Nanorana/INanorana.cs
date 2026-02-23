namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nanorana;

/// <summary>
/// Interface defining characteristics of Nanorana (genus).
/// </summary>
public interface INanorana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
