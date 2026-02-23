namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichogaster;

/// <summary>
/// Interface defining characteristics of Trichogaster (genus).
/// </summary>
public interface ITrichogaster
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
