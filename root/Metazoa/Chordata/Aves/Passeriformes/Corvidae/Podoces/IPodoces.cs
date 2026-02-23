namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Podoces;

/// <summary>
/// Interface defining characteristics of Podoces (genus).
/// </summary>
public interface IPodoces
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
