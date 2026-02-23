namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Tetragonuridae.Tetragonurus;

/// <summary>
/// Interface defining characteristics of Tetragonurus (genus).
/// </summary>
public interface ITetragonurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
