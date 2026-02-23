namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae.Acrobates;

/// <summary>
/// Interface defining characteristics of Acrobates (genus).
/// </summary>
public interface IAcrobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
