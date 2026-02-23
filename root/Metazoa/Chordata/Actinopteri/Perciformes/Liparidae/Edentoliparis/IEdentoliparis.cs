namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Edentoliparis;

/// <summary>
/// Interface defining characteristics of Edentoliparis (genus).
/// </summary>
public interface IEdentoliparis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
