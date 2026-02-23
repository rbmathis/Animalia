namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Notoliparis;

/// <summary>
/// Interface defining characteristics of Notoliparis (genus).
/// </summary>
public interface INotoliparis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
