namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae.Distoechurus;

/// <summary>
/// Interface defining characteristics of Distoechurus (genus).
/// </summary>
public interface IDistoechurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
