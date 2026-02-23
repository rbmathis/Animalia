namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Chelonia;

/// <summary>
/// Interface defining characteristics of Chelonia (genus).
/// </summary>
public interface IChelonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
