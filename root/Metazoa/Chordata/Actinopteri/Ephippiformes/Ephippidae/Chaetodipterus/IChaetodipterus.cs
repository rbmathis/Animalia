namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Chaetodipterus;

/// <summary>
/// Interface defining characteristics of Chaetodipterus (genus).
/// </summary>
public interface IChaetodipterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
