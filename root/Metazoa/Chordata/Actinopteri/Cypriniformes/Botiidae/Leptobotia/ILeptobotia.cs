namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Leptobotia;

/// <summary>
/// Interface defining characteristics of Leptobotia (genus).
/// </summary>
public interface ILeptobotia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
