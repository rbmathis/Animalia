namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Interface defining characteristics of Hyla (genus).
/// </summary>
public interface IHyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
