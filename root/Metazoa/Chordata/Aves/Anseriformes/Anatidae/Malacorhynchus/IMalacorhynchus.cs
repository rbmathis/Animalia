namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Malacorhynchus;

/// <summary>
/// Interface defining characteristics of Malacorhynchus (genus).
/// </summary>
public interface IMalacorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
