namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Gymnorhinus;

/// <summary>
/// Interface defining characteristics of Gymnorhinus (genus).
/// </summary>
public interface IGymnorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
