namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Trachyscorpia;

/// <summary>
/// Interface defining characteristics of Trachyscorpia (genus).
/// </summary>
public interface ITrachyscorpia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
