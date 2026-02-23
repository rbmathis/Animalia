namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Tetracamphilius;

/// <summary>
/// Interface defining characteristics of Tetracamphilius (genus).
/// </summary>
public interface ITetracamphilius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
