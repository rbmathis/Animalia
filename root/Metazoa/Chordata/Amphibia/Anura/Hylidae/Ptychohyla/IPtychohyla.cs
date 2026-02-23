namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ptychohyla;

/// <summary>
/// Interface defining characteristics of Ptychohyla (genus).
/// </summary>
public interface IPtychohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
