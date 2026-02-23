namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Acestrorhamphidae_polyphyletic_genera.Psalidodon;

/// <summary>
/// Interface defining characteristics of Psalidodon (genus).
/// </summary>
public interface IPsalidodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
