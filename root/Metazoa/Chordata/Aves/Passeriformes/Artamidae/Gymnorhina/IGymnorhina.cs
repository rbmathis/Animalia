namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Gymnorhina;

/// <summary>
/// Interface defining characteristics of Gymnorhina (genus).
/// </summary>
public interface IGymnorhina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
