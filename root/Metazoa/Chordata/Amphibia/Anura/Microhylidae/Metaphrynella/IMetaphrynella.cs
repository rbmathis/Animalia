namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Metaphrynella;

/// <summary>
/// Interface defining characteristics of Metaphrynella (genus).
/// </summary>
public interface IMetaphrynella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
