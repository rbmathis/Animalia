namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Parabrotulidae.Parabrotula;

/// <summary>
/// Interface defining characteristics of Parabrotula (genus).
/// </summary>
public interface IParabrotula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
