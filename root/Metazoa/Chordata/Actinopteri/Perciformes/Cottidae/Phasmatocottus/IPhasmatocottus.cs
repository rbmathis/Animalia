namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Phasmatocottus;

/// <summary>
/// Interface defining characteristics of Phasmatocottus (genus).
/// </summary>
public interface IPhasmatocottus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
