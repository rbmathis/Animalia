namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Neochen;

/// <summary>
/// Interface defining characteristics of Neochen (genus).
/// </summary>
public interface INeochen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
