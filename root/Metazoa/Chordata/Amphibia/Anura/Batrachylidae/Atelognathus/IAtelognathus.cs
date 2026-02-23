namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Atelognathus;

/// <summary>
/// Interface defining characteristics of Atelognathus (genus).
/// </summary>
public interface IAtelognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
