namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Pseudoliparis;

/// <summary>
/// Interface defining characteristics of Pseudoliparis (genus).
/// </summary>
public interface IPseudoliparis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
