namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Neomyxine;

/// <summary>
/// Interface defining characteristics of Neomyxine (genus).
/// </summary>
public interface INeomyxine
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
