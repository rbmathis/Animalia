namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Micromyzon;

/// <summary>
/// Interface defining characteristics of Micromyzon (genus).
/// </summary>
public interface IMicromyzon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
