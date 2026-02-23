namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pulchrana;

/// <summary>
/// Interface defining characteristics of Pulchrana (genus).
/// </summary>
public interface IPulchrana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
