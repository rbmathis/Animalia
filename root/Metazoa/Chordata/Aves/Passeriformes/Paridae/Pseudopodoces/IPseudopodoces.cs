namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pseudopodoces;

/// <summary>
/// Interface defining characteristics of Pseudopodoces (genus).
/// </summary>
public interface IPseudopodoces
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
