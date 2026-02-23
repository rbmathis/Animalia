namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leptailurus;

/// <summary>
/// Interface defining characteristics of Leptailurus (genus).
/// </summary>
public interface ILeptailurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
