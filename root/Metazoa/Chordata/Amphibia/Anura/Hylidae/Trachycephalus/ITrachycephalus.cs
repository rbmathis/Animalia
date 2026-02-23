namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

/// <summary>
/// Interface defining characteristics of Trachycephalus (genus).
/// </summary>
public interface ITrachycephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
