namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rheobatrachidae.Rheobatrachus;

/// <summary>
/// Interface defining characteristics of Rheobatrachus (genus).
/// </summary>
public interface IRheobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
