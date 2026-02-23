namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Wakea;

/// <summary>
/// Interface defining characteristics of Wakea (genus).
/// </summary>
public interface IWakea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
