namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Pseudochirops;

/// <summary>
/// Interface defining characteristics of Pseudochirops (genus).
/// </summary>
public interface IPseudochirops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
