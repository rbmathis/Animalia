namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Rollulus;

/// <summary>
/// Interface defining characteristics of Rollulus (genus).
/// </summary>
public interface IRollulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
