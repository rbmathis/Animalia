namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Phycis;

/// <summary>
/// Interface defining characteristics of Phycis (genus).
/// </summary>
public interface IPhycis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
