namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Bentartia;

/// <summary>
/// Interface defining characteristics of Bentartia (genus).
/// </summary>
public interface IBentartia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
