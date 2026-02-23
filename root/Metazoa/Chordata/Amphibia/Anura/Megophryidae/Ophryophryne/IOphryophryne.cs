namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Ophryophryne;

/// <summary>
/// Interface defining characteristics of Ophryophryne (genus).
/// </summary>
public interface IOphryophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
