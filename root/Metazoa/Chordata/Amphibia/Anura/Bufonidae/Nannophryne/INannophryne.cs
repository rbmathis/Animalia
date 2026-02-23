namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nannophryne;

/// <summary>
/// Interface defining characteristics of Nannophryne (genus).
/// </summary>
public interface INannophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
