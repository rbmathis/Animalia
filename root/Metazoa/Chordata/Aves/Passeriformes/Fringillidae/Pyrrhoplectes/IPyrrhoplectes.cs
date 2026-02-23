namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pyrrhoplectes;

/// <summary>
/// Interface defining characteristics of Pyrrhoplectes (genus).
/// </summary>
public interface IPyrrhoplectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
