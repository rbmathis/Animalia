namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anatidae_incertae_sedis.Nettapus;

/// <summary>
/// Interface defining characteristics of Nettapus (genus).
/// </summary>
public interface INettapus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
