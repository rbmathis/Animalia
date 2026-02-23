namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nibea;

/// <summary>
/// Interface defining characteristics of Nibea (genus).
/// </summary>
public interface INibea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
