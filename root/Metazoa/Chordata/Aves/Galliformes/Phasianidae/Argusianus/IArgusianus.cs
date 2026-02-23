namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Argusianus;

/// <summary>
/// Interface defining characteristics of Argusianus (genus).
/// </summary>
public interface IArgusianus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
