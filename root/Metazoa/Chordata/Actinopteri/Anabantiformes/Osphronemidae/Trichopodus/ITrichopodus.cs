namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichopodus;

/// <summary>
/// Interface defining characteristics of Trichopodus (genus).
/// </summary>
public interface ITrichopodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
