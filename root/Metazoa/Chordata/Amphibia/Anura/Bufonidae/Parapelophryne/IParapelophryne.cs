namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Parapelophryne;

/// <summary>
/// Interface defining characteristics of Parapelophryne (genus).
/// </summary>
public interface IParapelophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
