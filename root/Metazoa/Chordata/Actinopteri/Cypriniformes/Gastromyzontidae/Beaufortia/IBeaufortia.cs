namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Beaufortia;

/// <summary>
/// Interface defining characteristics of Beaufortia (genus).
/// </summary>
public interface IBeaufortia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
