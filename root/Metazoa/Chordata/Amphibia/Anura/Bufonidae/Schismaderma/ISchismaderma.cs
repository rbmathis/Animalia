namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Schismaderma;

/// <summary>
/// Interface defining characteristics of Schismaderma (genus).
/// </summary>
public interface ISchismaderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
