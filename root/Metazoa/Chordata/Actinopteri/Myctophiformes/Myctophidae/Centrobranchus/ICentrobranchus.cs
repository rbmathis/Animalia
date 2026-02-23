namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Centrobranchus;

/// <summary>
/// Interface defining characteristics of Centrobranchus (genus).
/// </summary>
public interface ICentrobranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
