namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bokermannohyla;

/// <summary>
/// Interface defining characteristics of Bokermannohyla (genus).
/// </summary>
public interface IBokermannohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
