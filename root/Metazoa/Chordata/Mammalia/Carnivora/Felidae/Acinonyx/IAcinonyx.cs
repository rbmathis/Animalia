namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Acinonyx;

/// <summary>
/// Interface defining characteristics of Acinonyx (genus).
/// </summary>
public interface IAcinonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
