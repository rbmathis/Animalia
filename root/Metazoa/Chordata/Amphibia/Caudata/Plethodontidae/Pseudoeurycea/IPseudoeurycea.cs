namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Pseudoeurycea;

/// <summary>
/// Interface defining characteristics of Pseudoeurycea (genus).
/// </summary>
public interface IPseudoeurycea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
