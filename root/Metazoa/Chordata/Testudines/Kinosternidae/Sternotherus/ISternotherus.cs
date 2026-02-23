namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Interface defining characteristics of Sternotherus (genus).
/// </summary>
public interface ISternotherus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
