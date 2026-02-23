namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homaloptera;

/// <summary>
/// Interface defining characteristics of Homaloptera (genus).
/// </summary>
public interface IHomaloptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
