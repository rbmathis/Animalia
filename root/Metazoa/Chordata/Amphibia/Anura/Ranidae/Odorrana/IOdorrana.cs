namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Odorrana;

/// <summary>
/// Interface defining characteristics of Odorrana (genus).
/// </summary>
public interface IOdorrana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
