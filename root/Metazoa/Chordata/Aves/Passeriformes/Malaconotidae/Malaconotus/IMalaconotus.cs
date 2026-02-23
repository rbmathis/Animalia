namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Malaconotus;

/// <summary>
/// Interface defining characteristics of Malaconotus (genus).
/// </summary>
public interface IMalaconotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
