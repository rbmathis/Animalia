namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

/// <summary>
/// Interface defining characteristics of Chinchilla (genus).
/// </summary>
public interface IChinchilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
