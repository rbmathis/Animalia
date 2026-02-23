namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leiopelmatidae.Leiopelma;

/// <summary>
/// Interface defining characteristics of Leiopelma (genus).
/// </summary>
public interface ILeiopelma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
