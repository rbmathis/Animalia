namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Syncrossus;

/// <summary>
/// Interface defining characteristics of Syncrossus (genus).
/// </summary>
public interface ISyncrossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
