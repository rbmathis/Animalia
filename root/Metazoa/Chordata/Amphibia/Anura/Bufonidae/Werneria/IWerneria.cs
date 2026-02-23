namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Werneria;

/// <summary>
/// Interface defining characteristics of Werneria (genus).
/// </summary>
public interface IWerneria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
