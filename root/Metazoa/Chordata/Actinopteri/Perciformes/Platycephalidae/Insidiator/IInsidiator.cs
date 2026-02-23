namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Insidiator;

/// <summary>
/// Interface defining characteristics of Insidiator (genus).
/// </summary>
public interface IInsidiator
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
