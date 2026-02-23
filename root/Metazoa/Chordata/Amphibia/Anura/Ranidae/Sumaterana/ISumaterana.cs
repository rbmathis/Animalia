namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sumaterana;

/// <summary>
/// Interface defining characteristics of Sumaterana (genus).
/// </summary>
public interface ISumaterana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
