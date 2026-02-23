namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Macropodus;

/// <summary>
/// Interface defining characteristics of Macropodus (genus).
/// </summary>
public interface IMacropodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
