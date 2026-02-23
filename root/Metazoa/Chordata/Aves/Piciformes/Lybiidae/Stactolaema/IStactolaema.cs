namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Stactolaema;

/// <summary>
/// Interface defining characteristics of Stactolaema (genus).
/// </summary>
public interface IStactolaema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
