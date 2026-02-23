namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Syrmaticus;

/// <summary>
/// Interface defining characteristics of Syrmaticus (genus).
/// </summary>
public interface ISyrmaticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
