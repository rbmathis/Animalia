namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Micrathene;

/// <summary>
/// Interface defining characteristics of Micrathene (genus).
/// </summary>
public interface IMicrathene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
