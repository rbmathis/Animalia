namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pelophryne;

/// <summary>
/// Interface defining characteristics of Pelophryne (genus).
/// </summary>
public interface IPelophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
