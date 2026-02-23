namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Gymnapistes;

/// <summary>
/// Interface defining characteristics of Gymnapistes (genus).
/// </summary>
public interface IGymnapistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
