namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Xiphiidae.Xiphias;

/// <summary>
/// Interface defining characteristics of Xiphias (genus).
/// </summary>
public interface IXiphias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
