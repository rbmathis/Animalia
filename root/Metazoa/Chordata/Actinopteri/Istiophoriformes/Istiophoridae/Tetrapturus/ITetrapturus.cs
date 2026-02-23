namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Tetrapturus;

/// <summary>
/// Interface defining characteristics of Tetrapturus (genus).
/// </summary>
public interface ITetrapturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
