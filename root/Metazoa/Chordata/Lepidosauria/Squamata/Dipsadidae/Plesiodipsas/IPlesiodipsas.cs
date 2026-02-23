namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Plesiodipsas;

/// <summary>
/// Interface defining characteristics of Plesiodipsas (genus).
/// </summary>
public interface IPlesiodipsas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
