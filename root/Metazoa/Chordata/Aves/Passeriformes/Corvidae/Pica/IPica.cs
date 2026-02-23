namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pica;

/// <summary>
/// Interface defining characteristics of Pica (genus).
/// </summary>
public interface IPica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
