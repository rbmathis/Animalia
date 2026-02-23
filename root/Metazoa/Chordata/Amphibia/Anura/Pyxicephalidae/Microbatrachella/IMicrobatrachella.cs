namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Microbatrachella;

/// <summary>
/// Interface defining characteristics of Microbatrachella (genus).
/// </summary>
public interface IMicrobatrachella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
