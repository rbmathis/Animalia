namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Melanocharis;

/// <summary>
/// Interface defining characteristics of Melanocharis (genus).
/// </summary>
public interface IMelanocharis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
