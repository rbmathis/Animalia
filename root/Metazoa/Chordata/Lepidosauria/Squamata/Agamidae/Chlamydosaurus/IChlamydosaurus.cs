namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Chlamydosaurus;

/// <summary>
/// Interface defining characteristics of Chlamydosaurus (genus).
/// </summary>
public interface IChlamydosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
