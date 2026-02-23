namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Sphaerotheca;

/// <summary>
/// Interface defining characteristics of Sphaerotheca (genus).
/// </summary>
public interface ISphaerotheca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
