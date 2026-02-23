namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Syncope;

/// <summary>
/// Interface defining characteristics of Syncope (genus).
/// </summary>
public interface ISyncope
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
