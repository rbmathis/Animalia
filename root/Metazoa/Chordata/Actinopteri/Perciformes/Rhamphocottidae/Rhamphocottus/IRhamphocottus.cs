namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Rhamphocottidae.Rhamphocottus;

/// <summary>
/// Interface defining characteristics of Rhamphocottus (genus).
/// </summary>
public interface IRhamphocottus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
