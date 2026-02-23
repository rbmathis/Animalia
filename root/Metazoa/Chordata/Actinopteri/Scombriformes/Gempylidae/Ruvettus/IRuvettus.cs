namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Ruvettus;

/// <summary>
/// Interface defining characteristics of Ruvettus (genus).
/// </summary>
public interface IRuvettus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
