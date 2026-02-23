namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Mannophryne;

/// <summary>
/// Interface defining characteristics of Mannophryne (genus).
/// </summary>
public interface IMannophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
