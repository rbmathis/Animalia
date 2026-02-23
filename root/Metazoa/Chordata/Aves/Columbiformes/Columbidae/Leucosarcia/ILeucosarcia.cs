namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leucosarcia;

/// <summary>
/// Interface defining characteristics of Leucosarcia (genus).
/// </summary>
public interface ILeucosarcia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
