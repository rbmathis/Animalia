namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Tentoriceps;

/// <summary>
/// Interface defining characteristics of Tentoriceps (genus).
/// </summary>
public interface ITentoriceps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
