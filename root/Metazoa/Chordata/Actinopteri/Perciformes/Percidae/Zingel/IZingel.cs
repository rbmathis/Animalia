namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Zingel;

/// <summary>
/// Interface defining characteristics of Zingel (genus).
/// </summary>
public interface IZingel
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
