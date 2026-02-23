namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Adelophryne;

/// <summary>
/// Interface defining characteristics of Adelophryne (genus).
/// </summary>
public interface IAdelophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
