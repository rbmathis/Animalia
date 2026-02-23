namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Rhyaconastes;

/// <summary>
/// Interface defining characteristics of Rhyaconastes (genus).
/// </summary>
public interface IRhyaconastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
