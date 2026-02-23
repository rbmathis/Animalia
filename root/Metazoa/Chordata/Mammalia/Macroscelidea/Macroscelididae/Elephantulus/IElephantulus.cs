namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus;

/// <summary>
/// Interface defining characteristics of Elephantulus (genus).
/// </summary>
public interface IElephantulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
