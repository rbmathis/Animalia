namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Toxorhamphus;

/// <summary>
/// Interface defining characteristics of Toxorhamphus (genus).
/// </summary>
public interface IToxorhamphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
