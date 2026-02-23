namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Crepidophryne;

/// <summary>
/// Interface defining characteristics of Crepidophryne (genus).
/// </summary>
public interface ICrepidophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
