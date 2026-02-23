namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mini;

/// <summary>
/// Interface defining characteristics of Mini (genus).
/// </summary>
public interface IMini
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
