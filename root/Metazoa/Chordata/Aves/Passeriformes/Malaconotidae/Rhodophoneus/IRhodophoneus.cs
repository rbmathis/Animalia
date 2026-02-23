namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Rhodophoneus;

/// <summary>
/// Interface defining characteristics of Rhodophoneus (genus).
/// </summary>
public interface IRhodophoneus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
