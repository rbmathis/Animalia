namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Myersiohyla;

/// <summary>
/// Interface defining characteristics of Myersiohyla (genus).
/// </summary>
public interface IMyersiohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
