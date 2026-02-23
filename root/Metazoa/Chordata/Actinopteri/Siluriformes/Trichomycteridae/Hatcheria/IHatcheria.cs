namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Hatcheria;

/// <summary>
/// Interface defining characteristics of Hatcheria (genus).
/// </summary>
public interface IHatcheria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
