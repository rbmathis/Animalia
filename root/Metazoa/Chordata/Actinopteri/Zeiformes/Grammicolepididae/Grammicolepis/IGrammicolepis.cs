namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Grammicolepididae.Grammicolepis;

/// <summary>
/// Interface defining characteristics of Grammicolepis (genus).
/// </summary>
public interface IGrammicolepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
