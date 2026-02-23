namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Alepisauridae.Omosudis;

/// <summary>
/// Interface defining characteristics of Omosudis (genus).
/// </summary>
public interface IOmosudis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
