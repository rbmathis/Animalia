namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Trachyboa;

/// <summary>
/// Interface defining characteristics of Trachyboa (genus).
/// </summary>
public interface ITrachyboa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
