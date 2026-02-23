namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Anomaloglossus;

/// <summary>
/// Interface defining characteristics of Anomaloglossus (genus).
/// </summary>
public interface IAnomaloglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
