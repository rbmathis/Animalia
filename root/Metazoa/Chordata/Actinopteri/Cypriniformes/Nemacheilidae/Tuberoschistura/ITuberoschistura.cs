namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Tuberoschistura;

/// <summary>
/// Interface defining characteristics of Tuberoschistura (genus).
/// </summary>
public interface ITuberoschistura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
