namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scarthyla;

/// <summary>
/// Interface defining characteristics of Scarthyla (genus).
/// </summary>
public interface IScarthyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
