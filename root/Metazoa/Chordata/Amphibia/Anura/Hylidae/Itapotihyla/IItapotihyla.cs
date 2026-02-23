namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Itapotihyla;

/// <summary>
/// Interface defining characteristics of Itapotihyla (genus).
/// </summary>
public interface IItapotihyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
