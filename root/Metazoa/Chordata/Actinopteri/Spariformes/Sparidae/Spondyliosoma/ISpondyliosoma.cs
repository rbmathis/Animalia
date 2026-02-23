namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Spondyliosoma;

/// <summary>
/// Interface defining characteristics of Spondyliosoma (genus).
/// </summary>
public interface ISpondyliosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
