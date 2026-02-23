namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae.Neblinaphryne;

/// <summary>
/// Interface defining characteristics of Neblinaphryne (genus).
/// </summary>
public interface INeblinaphryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
