namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Persiophis;

/// <summary>
/// Interface defining characteristics of Persiophis (genus).
/// </summary>
public interface IPersiophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
