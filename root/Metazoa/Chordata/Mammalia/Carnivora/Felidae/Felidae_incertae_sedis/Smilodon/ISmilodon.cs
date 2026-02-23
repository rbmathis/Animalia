namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Smilodon;

/// <summary>
/// Interface defining characteristics of Smilodon (genus).
/// </summary>
public interface ISmilodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
