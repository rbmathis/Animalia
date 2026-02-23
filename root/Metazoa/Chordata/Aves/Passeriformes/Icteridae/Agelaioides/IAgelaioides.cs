namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaioides;

/// <summary>
/// Interface defining characteristics of Agelaioides (genus).
/// </summary>
public interface IAgelaioides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
