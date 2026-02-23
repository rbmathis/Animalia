namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Ixoreus;

/// <summary>
/// Interface defining characteristics of Ixoreus (genus).
/// </summary>
public interface IIxoreus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
