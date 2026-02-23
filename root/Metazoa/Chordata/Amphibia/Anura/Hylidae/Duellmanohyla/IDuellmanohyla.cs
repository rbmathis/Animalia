namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Duellmanohyla;

/// <summary>
/// Interface defining characteristics of Duellmanohyla (genus).
/// </summary>
public interface IDuellmanohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
