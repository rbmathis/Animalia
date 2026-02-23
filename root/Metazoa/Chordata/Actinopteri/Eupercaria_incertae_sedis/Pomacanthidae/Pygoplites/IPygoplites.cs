namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Pygoplites;

/// <summary>
/// Interface defining characteristics of Pygoplites (genus).
/// </summary>
public interface IPygoplites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
