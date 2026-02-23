namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gyrinocheilidae.Gyrinocheilus;

/// <summary>
/// Interface defining characteristics of Gyrinocheilus (genus).
/// </summary>
public interface IGyrinocheilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
