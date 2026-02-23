namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Panophrys;

/// <summary>
/// Interface defining characteristics of Panophrys (genus).
/// </summary>
public interface IPanophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
