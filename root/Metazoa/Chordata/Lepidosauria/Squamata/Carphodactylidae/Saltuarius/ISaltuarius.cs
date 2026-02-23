namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Saltuarius;

/// <summary>
/// Interface defining characteristics of Saltuarius (genus).
/// </summary>
public interface ISaltuarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
