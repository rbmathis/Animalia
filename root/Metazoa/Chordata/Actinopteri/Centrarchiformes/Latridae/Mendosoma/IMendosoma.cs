namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Mendosoma;

/// <summary>
/// Interface defining characteristics of Mendosoma (genus).
/// </summary>
public interface IMendosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
