namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hypocolidae.Hypocolius;

/// <summary>
/// Interface defining characteristics of Hypocolius (genus).
/// </summary>
public interface IHypocolius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
