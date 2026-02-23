namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Chromobotia;

/// <summary>
/// Interface defining characteristics of Chromobotia (genus).
/// </summary>
public interface IChromobotia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
