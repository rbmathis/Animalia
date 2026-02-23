namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Pseudoplectrurus;

/// <summary>
/// Interface defining characteristics of Pseudoplectrurus (genus).
/// </summary>
public interface IPseudoplectrurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
