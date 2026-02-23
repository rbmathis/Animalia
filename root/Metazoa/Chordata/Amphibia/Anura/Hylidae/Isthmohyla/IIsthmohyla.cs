namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Isthmohyla;

/// <summary>
/// Interface defining characteristics of Isthmohyla (genus).
/// </summary>
public interface IIsthmohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
