namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Mercurana;

/// <summary>
/// Interface defining characteristics of Mercurana (genus).
/// </summary>
public interface IMercurana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
