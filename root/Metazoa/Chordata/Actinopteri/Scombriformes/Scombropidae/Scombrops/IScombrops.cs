namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae.Scombrops;

/// <summary>
/// Interface defining characteristics of Scombrops (genus).
/// </summary>
public interface IScombrops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
