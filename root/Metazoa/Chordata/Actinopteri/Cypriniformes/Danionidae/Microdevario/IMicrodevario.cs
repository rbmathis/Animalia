namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Microdevario;

/// <summary>
/// Interface defining characteristics of Microdevario (genus).
/// </summary>
public interface IMicrodevario
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
