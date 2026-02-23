namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Peltophryne;

/// <summary>
/// Interface defining characteristics of Peltophryne (genus).
/// </summary>
public interface IPeltophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
