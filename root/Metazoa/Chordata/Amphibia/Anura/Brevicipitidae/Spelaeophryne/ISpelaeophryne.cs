namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Spelaeophryne;

/// <summary>
/// Interface defining characteristics of Spelaeophryne (genus).
/// </summary>
public interface ISpelaeophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
