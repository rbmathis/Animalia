namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Charadrahyla;

/// <summary>
/// Interface defining characteristics of Charadrahyla (genus).
/// </summary>
public interface ICharadrahyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
