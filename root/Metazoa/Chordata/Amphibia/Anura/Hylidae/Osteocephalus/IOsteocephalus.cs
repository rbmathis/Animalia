namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Interface defining characteristics of Osteocephalus (genus).
/// </summary>
public interface IOsteocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
