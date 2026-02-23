namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelasticus;

/// <summary>
/// Interface defining characteristics of Agelasticus (genus).
/// </summary>
public interface IAgelasticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
