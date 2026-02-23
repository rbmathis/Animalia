namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Turacoena;

/// <summary>
/// Interface defining characteristics of Turacoena (genus).
/// </summary>
public interface ITuracoena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
