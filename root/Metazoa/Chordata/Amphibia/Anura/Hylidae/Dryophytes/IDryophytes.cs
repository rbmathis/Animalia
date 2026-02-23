namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryophytes;

/// <summary>
/// Interface defining characteristics of Dryophytes (genus).
/// </summary>
public interface IDryophytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
