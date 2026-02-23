namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Nilssonia;

/// <summary>
/// Interface defining characteristics of Nilssonia (genus).
/// </summary>
public interface INilssonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
