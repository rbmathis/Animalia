namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stumpffia;

/// <summary>
/// Interface defining characteristics of Stumpffia (genus).
/// </summary>
public interface IStumpffia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
