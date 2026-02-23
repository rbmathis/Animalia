namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Chlorophoneus;

/// <summary>
/// Interface defining characteristics of Chlorophoneus (genus).
/// </summary>
public interface IChlorophoneus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
