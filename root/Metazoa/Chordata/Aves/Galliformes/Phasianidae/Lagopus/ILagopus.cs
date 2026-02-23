namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

/// <summary>
/// Interface defining characteristics of Lagopus (genus).
/// </summary>
public interface ILagopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
