namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Potorous;

/// <summary>
/// Interface defining characteristics of Potorous (genus).
/// </summary>
public interface IPotorous
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
