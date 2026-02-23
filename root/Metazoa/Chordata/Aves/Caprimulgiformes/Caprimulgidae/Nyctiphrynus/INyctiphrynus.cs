namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Nyctiphrynus;

/// <summary>
/// Interface defining characteristics of Nyctiphrynus (genus).
/// </summary>
public interface INyctiphrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
