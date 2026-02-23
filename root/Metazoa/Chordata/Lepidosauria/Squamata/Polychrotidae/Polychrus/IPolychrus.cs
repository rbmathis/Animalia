namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Polychrotidae.Polychrus;

/// <summary>
/// Interface defining characteristics of Polychrus (genus).
/// </summary>
public interface IPolychrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
