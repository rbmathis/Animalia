namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Orraya;

/// <summary>
/// Interface defining characteristics of Orraya (genus).
/// </summary>
public interface IOrraya
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
