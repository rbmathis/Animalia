namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidodon;

/// <summary>
/// Interface defining characteristics of Scelidodon (genus).
/// </summary>
public interface IScelidodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
