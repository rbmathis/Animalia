namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemitaeniochromis;

/// <summary>
/// Interface defining characteristics of Hemitaeniochromis (genus).
/// </summary>
public interface IHemitaeniochromis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
