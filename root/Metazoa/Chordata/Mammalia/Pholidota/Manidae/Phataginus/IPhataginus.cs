namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Phataginus;

/// <summary>
/// Interface defining characteristics of Phataginus (genus).
/// </summary>
public interface IPhataginus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
