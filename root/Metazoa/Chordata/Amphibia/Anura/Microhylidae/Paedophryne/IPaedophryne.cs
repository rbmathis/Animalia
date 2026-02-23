namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne;

/// <summary>
/// Interface defining characteristics of Paedophryne (genus).
/// </summary>
public interface IPaedophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
