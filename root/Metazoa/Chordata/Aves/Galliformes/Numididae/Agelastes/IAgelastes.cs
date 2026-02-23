namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Agelastes;

/// <summary>
/// Interface defining characteristics of Agelastes (genus).
/// </summary>
public interface IAgelastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
