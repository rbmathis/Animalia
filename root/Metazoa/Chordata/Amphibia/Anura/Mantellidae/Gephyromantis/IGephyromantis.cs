namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Gephyromantis;

/// <summary>
/// Interface defining characteristics of Gephyromantis (genus).
/// </summary>
public interface IGephyromantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
