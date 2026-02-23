namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Hypocryptadius;

/// <summary>
/// Interface defining characteristics of Hypocryptadius (genus).
/// </summary>
public interface IHypocryptadius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
