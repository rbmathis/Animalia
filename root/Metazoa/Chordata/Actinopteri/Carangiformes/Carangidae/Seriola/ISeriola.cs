namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Seriola;

/// <summary>
/// Interface defining characteristics of Seriola (genus).
/// </summary>
public interface ISeriola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
