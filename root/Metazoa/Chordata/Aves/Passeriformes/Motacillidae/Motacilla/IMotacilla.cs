namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Motacilla;

/// <summary>
/// Interface defining characteristics of Motacilla (genus).
/// </summary>
public interface IMotacilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
