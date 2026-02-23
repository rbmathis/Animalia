namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Barbarophryne;

/// <summary>
/// Interface defining characteristics of Barbarophryne (genus).
/// </summary>
public interface IBarbarophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
