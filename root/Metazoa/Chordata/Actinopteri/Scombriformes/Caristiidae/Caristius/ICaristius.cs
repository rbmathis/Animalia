namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Caristius;

/// <summary>
/// Interface defining characteristics of Caristius (genus).
/// </summary>
public interface ICaristius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
