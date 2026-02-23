namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hamptophryne;

/// <summary>
/// Interface defining characteristics of Hamptophryne (genus).
/// </summary>
public interface IHamptophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
