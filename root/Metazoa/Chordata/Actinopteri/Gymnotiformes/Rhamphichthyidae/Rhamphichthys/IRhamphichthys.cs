namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Rhamphichthys;

/// <summary>
/// Interface defining characteristics of Rhamphichthys (genus).
/// </summary>
public interface IRhamphichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
