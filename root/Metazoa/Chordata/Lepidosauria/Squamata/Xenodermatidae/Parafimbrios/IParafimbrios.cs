namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Parafimbrios;

/// <summary>
/// Interface defining characteristics of Parafimbrios (genus).
/// </summary>
public interface IParafimbrios
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
