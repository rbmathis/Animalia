namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Houbaropsis;

/// <summary>
/// Interface defining characteristics of Houbaropsis (genus).
/// </summary>
public interface IHoubaropsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
