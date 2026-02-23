namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Melanobatrachus;

/// <summary>
/// Interface defining characteristics of Melanobatrachus (genus).
/// </summary>
public interface IMelanobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
