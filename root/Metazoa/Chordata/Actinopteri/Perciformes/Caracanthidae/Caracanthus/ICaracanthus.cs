namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Caracanthidae.Caracanthus;

/// <summary>
/// Interface defining characteristics of Caracanthus (genus).
/// </summary>
public interface ICaracanthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
