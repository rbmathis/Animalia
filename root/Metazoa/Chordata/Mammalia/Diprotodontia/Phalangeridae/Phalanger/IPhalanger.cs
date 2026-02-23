namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Phalanger;

/// <summary>
/// Interface defining characteristics of Phalanger (genus).
/// </summary>
public interface IPhalanger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
