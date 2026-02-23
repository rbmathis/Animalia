namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Greenwoodochromis;

/// <summary>
/// Interface defining characteristics of Greenwoodochromis (genus).
/// </summary>
public interface IGreenwoodochromis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
