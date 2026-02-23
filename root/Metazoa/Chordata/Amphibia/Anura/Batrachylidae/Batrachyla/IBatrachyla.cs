namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Batrachyla;

/// <summary>
/// Interface defining characteristics of Batrachyla (genus).
/// </summary>
public interface IBatrachyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
