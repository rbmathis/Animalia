namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae.Bathymaster;

/// <summary>
/// Interface defining characteristics of Bathymaster (genus).
/// </summary>
public interface IBathymaster
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
