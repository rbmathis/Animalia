namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Caracal;

/// <summary>
/// Interface defining characteristics of Caracal (genus).
/// </summary>
public interface ICaracal
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
