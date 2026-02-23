namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhinodoras;

/// <summary>
/// Interface defining characteristics of Rhinodoras (genus).
/// </summary>
public interface IRhinodoras
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
