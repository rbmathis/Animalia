namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Latonia;

/// <summary>
/// Interface defining characteristics of Latonia (genus).
/// </summary>
public interface ILatonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
