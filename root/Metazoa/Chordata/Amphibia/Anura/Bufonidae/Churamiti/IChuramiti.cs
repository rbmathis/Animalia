namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Churamiti;

/// <summary>
/// Interface defining characteristics of Churamiti (genus).
/// </summary>
public interface IChuramiti
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
