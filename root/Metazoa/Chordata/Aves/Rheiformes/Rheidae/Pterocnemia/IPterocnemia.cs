namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Rheiformes.Rheidae.Pterocnemia;

/// <summary>
/// Interface defining characteristics of Pterocnemia (genus).
/// </summary>
public interface IPterocnemia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
