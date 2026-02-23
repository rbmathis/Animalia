namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Margarops;

/// <summary>
/// Interface defining characteristics of Margarops (genus).
/// </summary>
public interface IMargarops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
