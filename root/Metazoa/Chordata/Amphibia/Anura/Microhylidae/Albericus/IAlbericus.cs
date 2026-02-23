namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Albericus;

/// <summary>
/// Interface defining characteristics of Albericus (genus).
/// </summary>
public interface IAlbericus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
