namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Derepodichthys;

/// <summary>
/// Interface defining characteristics of Derepodichthys (genus).
/// </summary>
public interface IDerepodichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
