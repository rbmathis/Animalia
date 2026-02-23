namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae.Sundadanio;

/// <summary>
/// Interface defining characteristics of Sundadanio (genus).
/// </summary>
public interface ISundadanio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
