namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Poyntonophrynus;

/// <summary>
/// Interface defining characteristics of Poyntonophrynus (genus).
/// </summary>
public interface IPoyntonophrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
