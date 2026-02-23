namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Liophryne;

/// <summary>
/// Interface defining characteristics of Liophryne (genus).
/// </summary>
public interface ILiophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
