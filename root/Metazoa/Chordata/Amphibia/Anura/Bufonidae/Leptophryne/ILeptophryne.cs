namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Leptophryne;

/// <summary>
/// Interface defining characteristics of Leptophryne (genus).
/// </summary>
public interface ILeptophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
