namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Mertensophryne;

/// <summary>
/// Interface defining characteristics of Mertensophryne (genus).
/// </summary>
public interface IMertensophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
