namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Brosme;

/// <summary>
/// Interface defining characteristics of Brosme (genus).
/// </summary>
public interface IBrosme
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
