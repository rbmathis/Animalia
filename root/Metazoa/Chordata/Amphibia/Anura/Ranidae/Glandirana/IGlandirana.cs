namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Glandirana;

/// <summary>
/// Interface defining characteristics of Glandirana (genus).
/// </summary>
public interface IGlandirana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
