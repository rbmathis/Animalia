namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhabdornithidae.Rhabdornis;

/// <summary>
/// Interface defining characteristics of Rhabdornis (genus).
/// </summary>
public interface IRhabdornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
