namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Aplodontiidae.Aplodontia;

/// <summary>
/// Interface defining characteristics of Aplodontia (genus).
/// </summary>
public interface IAplodontia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
