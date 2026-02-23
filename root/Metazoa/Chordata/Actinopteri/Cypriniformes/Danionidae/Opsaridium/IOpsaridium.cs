namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsaridium;

/// <summary>
/// Interface defining characteristics of Opsaridium (genus).
/// </summary>
public interface IOpsaridium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
