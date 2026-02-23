namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Urophycis;

/// <summary>
/// Interface defining characteristics of Urophycis (genus).
/// </summary>
public interface IUrophycis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
