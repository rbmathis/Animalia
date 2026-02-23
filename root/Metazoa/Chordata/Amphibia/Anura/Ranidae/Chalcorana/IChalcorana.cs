namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Chalcorana;

/// <summary>
/// Interface defining characteristics of Chalcorana (genus).
/// </summary>
public interface IChalcorana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
